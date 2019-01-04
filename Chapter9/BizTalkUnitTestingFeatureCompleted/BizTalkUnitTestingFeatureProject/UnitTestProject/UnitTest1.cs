using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BizTalkUnitTestingFeatureProject;
using System.IO;
using System.Collections.Specialized;
using System.Collections.Generic;


namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        //Used to save the message example instances
        public string IncomingBookOrdersInstance = "";

       
        [TestMethod]
        public void ValidTestIncomingBookOrderSchema()
        {
            //example test method that provides a valid message
            #region Arrange
            bool boolTestOK = false;
            BizTalkUnitTestingFeatureProject.IncomingBookOrders IncomingBookOrdersSchema = new IncomingBookOrders();
            //replace the IncomingBookOrdersInstance with your instance file
            IncomingBookOrdersInstance = @"C:\APRESS\Chapter8\BizTalkUnitTestingFeature\BizTalkUnitTestingFeatureProject\BizTalkUnitTestingFeatureProject\MessageInstances\IncomingBookOrders\ValidMessages\ValidIncomingBookOrders_1_Book.xml";
            #endregion Arrange

            #region Act
            boolTestOK = IncomingBookOrdersSchema.ValidateInstance(IncomingBookOrdersInstance, Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.XML);
            #endregion Act

            #region Assert
            Assert.IsTrue(boolTestOK);
            #endregion Assert
        }

        [TestMethod]
        public void WrongTestIncomingBookOrderSchema()
        {
            //example test method that provides a wrong message
            #region Arrange
            bool boolTestOK = false;
            BizTalkUnitTestingFeatureProject.IncomingBookOrders IncomingBookOrdersSchema = new IncomingBookOrders();
            //replace the IncomingBookOrdersInstance with your instance file
            IncomingBookOrdersInstance = @"C:\APRESS\Chapter8\BizTalkUnitTestingFeature\BizTalkUnitTestingFeatureProject\BizTalkUnitTestingFeatureProject\MessageInstances\IncomingBookOrders\WrongMessages\WrongIncomingBookOrders_1_Book.xml";
            #endregion Arrange

            #region Act
            boolTestOK = IncomingBookOrdersSchema.ValidateInstance(IncomingBookOrdersInstance, Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.XML);
            #endregion Act

            #region Assert
            Assert.IsTrue(boolTestOK);
            #endregion Assert

        }

        [TestMethod]
        public void ValidInstanceMap()
        {
            //example test method that provides a wrong message
            #region Arrange
            bool boolTestOK = false;
            //replace the sOuputInstance with your output instance file
            string sOuputInstance = @"C:\APRESS\Chapter8\BizTalkUnitTestingFeature\BizTalkUnitTestingFeatureProject\BizTalkUnitTestingFeatureProject\MessageInstances\OutputInstances\ValidatedMapMessage.xml";
            //deleting the output instance
            if (File.Exists(sOuputInstance)) { File.Delete(sOuputInstance);}
            
            BizTalkUnitTestingFeatureProject.Map_IncomingBookOrders_To_CRMIncomingBookOrders map = new Map_IncomingBookOrders_To_CRMIncomingBookOrders();
            //replace the IncomingBookOrdersInstance with your instance file
            IncomingBookOrdersInstance = @"C:\APRESS\Chapter8\BizTalkUnitTestingFeature\BizTalkUnitTestingFeatureProject\BizTalkUnitTestingFeatureProject\MessageInstances\IncomingBookOrders\ValidMessages\ValidIncomingBookOrders_1_Book.xml";
            #endregion Arrange

            #region Act
            map.TestMap(IncomingBookOrdersInstance, Microsoft.BizTalk.TestTools.Schema.InputInstanceType.Xml, sOuputInstance, Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.XML);
            //in this case we will check if the out put file exists:
            var vFileInfo = new FileInfo(sOuputInstance);
            if (vFileInfo.Exists ) { boolTestOK = true; }
            #endregion Act

            #region Assert
            Assert.IsTrue(boolTestOK);
            #endregion Assert
        }

        [TestMethod]
        public void WrongInstanceMap()
        {
            //example test method that provides a wrong message
            #region Arrange
            bool boolTestOK = false;
            //replace the sOuputInstance with your output instance file
            string sOuputInstance = @"C:\APRESS\Chapter8\BizTalkUnitTestingFeature\BizTalkUnitTestingFeatureProject\BizTalkUnitTestingFeatureProject\MessageInstances\OutputInstances\ValidatedMapMessage.xml";
            //deleting the output instance
            if (File.Exists(sOuputInstance)) { File.Delete(sOuputInstance); }
            BizTalkUnitTestingFeatureProject.Map_IncomingBookOrders_To_CRMIncomingBookOrders map = new Map_IncomingBookOrders_To_CRMIncomingBookOrders();
            //replace the IncomingBookOrdersInstance with your wrong instance file
            IncomingBookOrdersInstance = @"C:\APRESS\Chapter8\BizTalkUnitTestingFeature\BizTalkUnitTestingFeatureProject\BizTalkUnitTestingFeatureProject\MessageInstances\IncomingBookOrders\WrongMessages\WrongIncomingBookOrders_1_Book.xml";
            #endregion Arrange

            #region Act
            map.TestMap(IncomingBookOrdersInstance, Microsoft.BizTalk.TestTools.Schema.InputInstanceType.Xml, sOuputInstance, Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.XML);
            //in this case we will check if the out put file exists or if the File is empty
            var vFileInfo= new FileInfo(sOuputInstance);
            if (!vFileInfo.Exists || vFileInfo.Length < 4) { boolTestOK = false; }

            #endregion Act

            #region Assert
            Assert.IsTrue(boolTestOK);
            #endregion Assert

        }

        [TestMethod()]
         public void FFReceivePipelineUnitTest()
        {

            #region Arrange
            //loading the flat file pipeline rcvPipBookOrdersFF from the BizTalk server project
            BizTalkUnitTestingFeatureProject.rcvPipBookOrdersFF target = new rcvPipBookOrdersFF();

            //the testpipeline method is expecting the incoming message as a stringCollection//  
            StringCollection documents = new StringCollection();
            IncomingBookOrdersInstance = @"C:\APRESS\Chapter8\BizTalkUnitTestingFeature\BizTalkUnitTestingFeatureProject\BizTalkUnitTestingFeatureProject\MessageInstances\IncomingBookOrders\ValidMessages\FFBooksOrder.txt";
            Assert.IsTrue(File.Exists(IncomingBookOrdersInstance));
            documents.Add(IncomingBookOrdersInstance);
            

            //Only a body part for this test message so an empty collection will be passed.                         ===//  
            StringCollection parts = new StringCollection();

            //The testpipeline method expects the schemas in a dictionary. 
            Dictionary<string, string> schemas = new Dictionary<string, string>();
            string SchemaFile = @"C:\APRESS\Chapter8\BizTalkUnitTestingFeature\BizTalkUnitTestingFeatureProject\BizTalkUnitTestingFeatureProject\BookOrdersCompleted.xsd";
            Assert.IsTrue(File.Exists(SchemaFile));
            schemas.Add("BizTalkUnitTestingFeatureProject.BookOrdersCompleted", SchemaFile);
            #endregion Arrange
            
            #region Act
            //=== Test the execution of the pipeline using the inputs ===//  
            target.TestPipeline(documents, parts, schemas);
            //=== Validate that the pipeline test produced the message ===//  
            //=== which conforms to the schema.                        ===//  
            #endregion Act

            #region Assert
            //Checking for the ouput file existance. If exits that means that the pipeline executed succesfully
            string[] strMessages = Directory.GetFiles(@"C:\APRESS\Chapter8\BizTalkUnitTestingFeature\BizTalkUnitTestingFeatureProject\UnitTestProject\bin\Debug", "Message*.out");
            Assert.IsTrue(strMessages.Length > 0);
            BizTalkUnitTestingFeatureProject.BookOrdersCompleted BookOrdersValidationSchema = new BookOrdersCompleted();
            foreach (string outFile in strMessages)
            {
                //for every ouput file we check if the message is valid calling the validateInstance method. 
                Assert.IsTrue(BookOrdersValidationSchema.ValidateInstance(outFile, Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.XML));
            }
            #endregion Assert
        }
    }
}
