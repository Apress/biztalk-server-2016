#region Using Directives
using System;
using System.IO;
using System.Diagnostics;
using System.Text;
using System.Xml;
using System.ServiceModel;
using System.ServiceModel.Channels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;


#endregion

namespace Microsoft.BizTalk.Samples
{
    [TestClass]
    public class BTSLoadTest
    {
        #region Constants
        private const int MaxBufferSize = 2097152;
        private const string Source = "BTS Load Test";
        private const string Star = "*";
        public const string TestMessageFolderParameter = "testMessageFolder";
        public const string TestMessageFolderDefault = @"C:\APRESS\Chapter8\BizTalkUnitTest\BizTalkUnitTest\BizTalkUnitTest";
        public const string TestMessageFolderFormat = @"Test Message Folder = {0}";
        public const string TestXmlDocument = "TestMessage.xml";
        #endregion

        #region Private Instance Fields
        private TestContext testContextInstance;
        #endregion

        

        #region Private ThreadStatic Fields
        [ThreadStatic]
        private static ChannelFactory<IRequestChannel> channelFactory;
        [ThreadStatic]
        private static IRequestChannel channel = null;
        [ThreadStatic]
        private static byte[] buffer = null;
        #endregion

        #region Private Static Fields
        private static string testMessageFolder = null;
        #endregion

        #region Public Instance Constructor
        public BTSLoadTest()
        {
        }
        #endregion

        #region Public Static Constructor
        static BTSLoadTest()
        {
            try
            {
                testMessageFolder = ConfigurationManager.AppSettings[TestMessageFolderParameter];
                if (string.IsNullOrEmpty(testMessageFolder))
                {
                    testMessageFolder = TestMessageFolderDefault;
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
                EventLog.WriteEntry(Source, ex.Message, EventLogEntryType.Error);
            }
        }
        #endregion

        #region Public Properties
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext1
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        #endregion

        #region Test Methods

        [TestMethod]
        public void BTSMessaging()
        {

            
            InvokeBizTalkReceiveLocation("BTSMessagingEP",
                                           testMessageFolder,
                                           TestXmlDocument,
                                           MessageVersion.Default,
                                           SessionMode.Allowed);
        }

        [TestMethod]
        public void BTSMessaging2()
        {
            InvokeBizTalkReceiveLocation("BTSMessagingEP2",
                                           testMessageFolder,
                                           TestXmlDocument,
                                           MessageVersion.Default,
                                           SessionMode.Allowed);
        }

        [TestMethod]
        public void BTSOrchestration()
        {
            InvokeBizTalkReceiveLocation("BTSOrchestrationEP",
                                           testMessageFolder,
                                           TestXmlDocument,
                                           MessageVersion.Default,
                                           SessionMode.Allowed);
        }
        #endregion

        #region Helper Methods
        public void InvokeBizTalkReceiveLocation(string endpointConfigurationName,
                                           string requestMessageFolder,
                                           string requestMessageName,
                                           MessageVersion messageVersion,
                                           SessionMode sessionMode)
        {
            XmlTextReader xmlTextReader = null;
            Message requestMessage = null;
            Message responseMessage = null;

            try
            {
                if (channel == null || channel.State != CommunicationState.Opened)
                {
                    channelFactory = new ChannelFactory<IRequestChannel>(endpointConfigurationName);
                    channelFactory.Endpoint.Contract.SessionMode = sessionMode;
                    channel = channelFactory.CreateChannel();
                }
                if (buffer == null)
                {
                    string path = Path.Combine(requestMessageFolder, requestMessageName);

                    string message;
                    using (StreamReader reader = new StreamReader(File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read)))
                    {
                        message = reader.ReadToEnd();
                    }
                    buffer = Encoding.UTF8.GetBytes(message);
                }
                MemoryStream stream = new MemoryStream(buffer);
                xmlTextReader = new XmlTextReader(stream);
                requestMessage = Message.CreateMessage(messageVersion, Star, xmlTextReader);
               // testContextInstance.BeginTimer(requestMessageName);
                responseMessage = channel.Request(requestMessage);
            }
            catch (FaultException ex)
            {
                HandleException(ex);
                throw;
            }
            catch (CommunicationException ex)
            {
                HandleException(ex);
                throw;
            }
            catch (TimeoutException ex)
            {
                HandleException(ex);
                throw;
            }
            catch (Exception ex)
            {
                HandleException(ex);
                throw;
            }
            finally
            {
                //testContextInstance.EndTimer(requestMessageName);
                CloseObjects(xmlTextReader,
                             requestMessage,
                             responseMessage);
            }
        }

        private void HandleException(Exception ex)
        {
            try
            {
                Trace.WriteLine(ex.Message);
                EventLog.WriteEntry(Source, ex.Message, EventLogEntryType.Error);
            }
            catch (Exception)
            {
            }
        }

        private void CloseObjects(XmlTextReader xmlTextReader,
                           Message requestMessage,
                           Message responseMessage)
        {
            try
            {
                if (xmlTextReader != null)
                {
                    xmlTextReader.Close();
                }
                if (requestMessage != null)
                {
                    requestMessage.Close();
                }
                if (responseMessage != null)
                {
                    responseMessage.Close();
                }
            }
            catch (Exception)
            {
            }
        }

        #endregion
    }
}