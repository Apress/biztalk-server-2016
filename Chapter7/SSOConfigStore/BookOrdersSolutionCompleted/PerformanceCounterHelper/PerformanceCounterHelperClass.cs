using System;
using System.Diagnostics;
using System.Management;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceCounterHelper
{
    //This classs will create the following performance counters:
    //Orchestration Received: Number of usiness received for this orchestration
    //Orchestration Sent: Number of Business messages send for this orchestration
    
    [Serializable] //we mark the class as serializable so it could be initialized from any BizTalk orchestration
    public class PerformanceCounterHelperClass
    
        {
        public string sDefaultCategoryName = "BizTalkOrchestrations_";

        #region DefaultContructor
        public PerformanceCounterHelperClass(string sOrchestration,bool bForce = false)
        {
            //The default contructor will:
            
            //Install the orchestration counters in running server if they are not already created.
            //for the counters name, will use the orchestration name se you will have a separated counter per orchestration.
            //if you have multiple servers runningt he orchestration you must gather all of them to get the real number
            //this counter will be reset when the BizTalk host Instance running this orchestration restarts.
            sDefaultCategoryName = sDefaultCategoryName + sOrchestration;
            createCategory(sDefaultCategoryName, bForce);

        }

        #endregion DefaultConstructor
        #region Constructor with version number
        public PerformanceCounterHelperClass(string sOrchestration, string sVersion, bool bForce = false )
        {
            //The default contructor will:

            //Install the orchestration counters in running server if they are not already created.
            //for the counters name, will use the orchestration name se you will have a separated counter per orchestration.
            //if you have multiple servers runningt he orchestration you must gather all of them to get the real number
            //this counter will be reset when the BizTalk host Instance running this orchestration restarts.
            sDefaultCategoryName = sDefaultCategoryName + "_" + sVersion + "_" +sOrchestration;
            createCategory(sDefaultCategoryName, bForce);

        }
        #endregion Contrusctor with version number

        #region CreateCategory
        public bool  createCategory(string slCategoryName, bool bforce = false)
        {
            //returns true if the category can be created. This is just creating the category and the draft counters. 
            //as Counters are declared as multiInstance, they will be created and assigned every time a BizTalk HostInstance
            //process an orchestration of this type.
            //if force, the category will be deleted first and then recreated
            Boolean r = false;

            try
            {
                if (bforce) //if user is forcing re-creation
                {
                    //we delete the category first
                    if (PerformanceCounterCategory.Exists(slCategoryName))
                    {
                        PerformanceCounterCategory.Delete(slCategoryName); //we delte the category
                    }
                }
                if (!PerformanceCounterCategory.Exists(slCategoryName))
                {
                    //this is creating a collection of data counters. 
                    //We will use it at the end of the If to create Counter metadata configuration associated with the category.
                    CounterCreationDataCollection counters = new CounterCreationDataCollection();
                    //we create the counter #received messages
                    CounterCreationData receivedMessages = new CounterCreationData();
                    receivedMessages.CounterName = "# Received Messages";
                    receivedMessages.CounterHelp = "Total number of received messages";
                    receivedMessages.CounterType = PerformanceCounterType.NumberOfItems64;
                    counters.Add(receivedMessages);
                    //we create the counter #sent messages
                    CounterCreationData sendMessages = new CounterCreationData();
                    sendMessages.CounterName = "# Sent Messages";
                    sendMessages.CounterHelp = "Total number of sent messages";
                    sendMessages.CounterType = PerformanceCounterType.NumberOfItems64;
                    
                    counters.Add(sendMessages);

                    //Create a new category with the new orchestration performancecounters                    
                    //We set up the counters as multiInstances (PerformanceCounterCategoryType.MultiInstance)
                    //so we could add them later to the Host instance 
                    PerformanceCounterCategory.Create(slCategoryName, slCategoryName + " counters", PerformanceCounterCategoryType.MultiInstance, counters);                   
                }
                r = true;
            }
            catch (Exception)
            {
                r = false;
                throw;
            }
            return r;
        }

        

        #endregion CreateCategory
        #region addValueToACounter
        public  bool addValueToACounter(string sCounterFamilyName,string counterName,string realOrchestrationName)
        {
            bool r = false;
            string sCounterFullName = "";

            try
            {
                sCounterFullName = sDefaultCategoryName + sCounterFamilyName;
                System.Diagnostics.PerformanceCounter p = new PerformanceCounter();                
                p.CategoryName = sDefaultCategoryName;
                p.CounterName = counterName;
                //we build the instance name.                 
                p.InstanceName = returnHostInstanceNameForProcess(realOrchestrationName);
                //the following line will attach the counter to the BizTalk Process. If you want the counters to be independent of the host instance, 
                //Choose PerformanceCounterInstanceLifetime.Global.
                p.InstanceLifetime = PerformanceCounterInstanceLifetime.Process;
                p.ReadOnly = false;
                p.Increment(); //we increment the counter by 1.
                r = true; 
            }
            catch (Exception ex)
            {
                r = false;
                throw ex;
            }
            return r;
        }
        #endregion add ValueToACounter
        #region Helper Functions
      
        public string returnHostInstanceNameForProcess(string sOrchestration)
        {
            //based on the orchestration we will get the host name. 
            //with the host name we create the name of the Perf Counter instance 
            //following this nomenclature as BizTalk Server counters are following this Nomenclature:
            //"HostName:NameOfTheMEssageBoxDb:NameOfTheServer"
            
            string r= "";
            string sHostName="";
            string sServerName = Environment.MachineName;
            string sMessageBoxDbName = "";
            try
            {
                //As we are performing several WMI queries, we Create the WMI search object
                ManagementObjectSearcher Searcher = new ManagementObjectSearcher();
                //create the scope node so we can set the WMI root node correctly.
                ManagementScope Scope = new ManagementScope("root\\MicrosoftBizTalkServer");
                // Build a Query to enumerate the MSBTS_Orchestration filtered by parameter sOrchestration
                SelectQuery Query = new SelectQuery();
                Query.QueryString = "SELECT * FROM MSBTS_Orchestration WHERE Name Like '%" + sOrchestration + "%'";
                // Set the query and scope for the searcher.
                Searcher.Scope = Scope;
                Searcher.Query = Query;
                ManagementObjectCollection QueryCol = Searcher.Get();
                foreach (ManagementObject Inst in QueryCol)
                {
                    //Get the default host name for the orchestration.
                    sHostName = Inst.Properties["HostName"].Value.ToString();
                }
                //we get now the MessageBox database name:                 
                Query = new SelectQuery();
                Query.QueryString = "SELECT * FROM MSBTS_MsgBoxSetting";
                // Set the query for the searcher.
                Searcher.Query = Query;
                QueryCol = Searcher.Get();
                foreach (ManagementObject Inst2 in QueryCol)
                {
                    //Get the default host name for the orchestration.
                    sMessageBoxDbName = Inst2.Properties["MsgBoxDBName"].Value.ToString();
                }
                r = sHostName + ":" + sMessageBoxDbName + ":" + sServerName;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            return r;
        }
            #endregion Helper Functions


    } //end class PerformanceCounterHelperClass
    
} //End NameSpace

