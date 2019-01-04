
using System;
using System.Collections.Specialized;
using Microsoft.BizTalk.SSOClient.Interop;


namespace SSOClientHelper
{
    public class ConfigurationPropertyBag : IPropertyBag
    {
        private HybridDictionary properties;
        internal ConfigurationPropertyBag()
        {
            properties = new HybridDictionary();
        }
        public void Read(string propName, out object ptrVar, int errLog)
        {
            ptrVar = properties[propName];
        }
        public void Write(string propName, ref object ptrVar)
        {
            properties.Add(propName, ptrVar);
        }
        public bool Contains(string key)
        {
            return properties.Contains(key);
        }
        public void Remove(string key)
        {
            properties.Remove(key);
        }
    }
    [Serializable]
    public class SSOClientHelper
    {
        private static string idenifierGUID = "ConfigProperties";

        /// <summary>
        /// Read method helps get configuration data
        /// </summary>        
        /// <param name="appName">The name of the affiliate application to represent the configuration container to access</param>
        /// <param name="propName">The property name to read</param>
        /// <returns>
        ///  The value of the property stored in the given affiliate application of this component.
        /// </returns>
        public string Read(string appName, string propName)
        {
            try
            {
                SSOConfigStore ssoStore = new SSOConfigStore();
                ConfigurationPropertyBag appMgmtBag = new ConfigurationPropertyBag();
                ((ISSOConfigStore)ssoStore).GetConfigInfo(appName, idenifierGUID, SSOFlag.SSO_FLAG_RUNTIME, (IPropertyBag)appMgmtBag);
                object propertyValue = null;
                appMgmtBag.Read(propName, out propertyValue, 0);
                return (string)propertyValue;
            }
            catch (Exception e)
            {
                System.Diagnostics.Trace.WriteLine(e.Message);
                throw;
            }
        }
    }
}
