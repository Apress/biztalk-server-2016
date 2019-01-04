

namespace Microsoft.BizTalk.Pipelines.CustomComponent.PropertyGeneratorPipeline
{
    using System;
    using System.Resources;
    using System.Drawing;
    using System.Collections;
    using System.Reflection;
    using System.ComponentModel;
    using System.Text;
    using System.IO;
    using Microsoft.BizTalk.Message.Interop;
    using Microsoft.BizTalk.Component.Interop;

    //the component it is a pipeline
    [ComponentCategory(CategoryTypes.CATID_PipelineComponent)]
    //the component is a general component
    [ComponentCategory(CategoryTypes.CATID_Any)]
    //it can be used in the validate stage at the pipeline component.
    [ComponentCategory(CategoryTypes.CATID_Validate)]
    [System.Runtime.InteropServices.Guid("D7228F2E-65D2-4316-8997-0AA9A98A1BF3")]
    public class PropertyGeneratorPipeline : BaseCustomTypeDescriptor, 
        IBaseComponent, 
        Microsoft.BizTalk.Component.Interop.IComponent,
        Microsoft.BizTalk.Component.Interop.IPersistPropertyBag,
        IComponentUI
    {
        private string customPromotedPropertyName = null;
        private string customPromotedPropertyNameSpace = null;
        private string customPromotedPropertyValue = null;

        static ResourceManager resManager = new ResourceManager("Microsoft.BizTalk.Pipelines.CustomComponent.PropertyGeneratorPipeline", Assembly.GetExecutingAssembly());
            
        public PropertyGeneratorPipeline() : base(resManager)
        {
        }

        [
        MsgPropertyName("customPromotedPropertyNameProp"),
        MsgDescription("customPromotedPropertyNamePropText")
        ]
        public string PropertyName
        {
            get { return customPromotedPropertyName; }
            set { customPromotedPropertyName = value; }
        }

        [
      MsgPropertyName("customPromotedPropertyNameSpaceProp"),
      MsgDescription("customPromotedPropertyNameSpaceText")
      ]
        public string NameSpace
        {
            get { return customPromotedPropertyNameSpace; }
            set { customPromotedPropertyNameSpace = value; }
        }

        [
   MsgPropertyName("customPromotedPropertyValueProp"),
   MsgDescription("customPromotedPropertyValueText ")
   ]
        public string PropertyValue
        {
            get { return customPromotedPropertyValue; }
            set { customPromotedPropertyValue = value; }
        }

        #region IBaseComponent
        public string Description
        {
            get
            {
                 return "Custom Pipeline Component"; 
            }
        }

        public string Name
        {
            get { return "Property Generator Component"; }
        }

        public string Version
        {
            get
            {
                return "1.0";
            }
        }


        #endregion

        #region IComponent
        public IBaseMessage Execute(IPipelineContext pContext, IBaseMessage pInMsg)
        {
            try
            {
                IBaseMessageContext msgContext = pInMsg.Context;               
                msgContext.Write(customPromotedPropertyName, customPromotedPropertyNameSpace, customPromotedPropertyValue);
                msgContext.Promote(customPromotedPropertyName, customPromotedPropertyNameSpace, customPromotedPropertyValue);
            }
            catch (Exception ex)
            {
                if (pInMsg != null)
                {
                    pInMsg.SetErrorInfo(ex);
                }
                throw ex;
            }

            return pInMsg;
        }
        #endregion

        #region IPersistPropertyBag
        public void GetClassID(out Guid classID)
        {
            //classID = new System.Guid("2847C035-5A17-4CB1-A289-5A996E87DEE5");
            
            classID = new System.Guid("D7228F2E-65D2-4316-8997-0AA9A98A1BF3");

        }

        public void InitNew()
        {
            
        }

        public void Load(IPropertyBag propertyBag, int errorLog)
        {
            string val = (string)ReadPropertyBag(propertyBag, "NameSpace");
            if (val != null) customPromotedPropertyNameSpace = val;

            val = (string)ReadPropertyBag(propertyBag, "PropertyName");
            if (val != null) customPromotedPropertyName = val;

            val = (string)ReadPropertyBag(propertyBag, "PropertyValue");
            if (val != null) customPromotedPropertyValue = val;

        }

        public void Save(IPropertyBag propertyBag, bool clearDirty, bool saveAllProperties)
        {
            object val = (object)customPromotedPropertyNameSpace;
            WritePropertyBag(propertyBag, "NameSpace", val);

            val = (object)customPromotedPropertyName;
            WritePropertyBag(propertyBag, "PropertyName", val);

            val = (object)customPromotedPropertyNameSpace;
            WritePropertyBag(propertyBag, "PropertyValue", val);
        }

        private static object ReadPropertyBag(Microsoft.BizTalk.Component.Interop.IPropertyBag pb, string propName)
        {
            object val = null;
            try
            {
                pb.Read(propName, out val, 0);
            }

            catch (ArgumentException)
            {
                return val;
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            return val;
        }

            private static void WritePropertyBag(Microsoft.BizTalk.Component.Interop.IPropertyBag pb, string propName, object val)
        {
            try
            {
                pb.Write(propName, ref val);
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
        #endregion

        #region IComponentUI
        [Browsable(false)]
        public IntPtr Icon
        {
            get
            {
                return((Bitmap)resManager.GetObject("PipelineTool")).GetHicon();
            }
        }
        public IEnumerator Validate(object projectSystem)
        {
            IEnumerator enumerator = null;
            ArrayList strList = new ArrayList();

    
            if ((customPromotedPropertyNameSpace != null) &&
            (customPromotedPropertyNameSpace.Length >= 256))
            {
                strList.Add("Invalid Name Space");
            }

    
            if ((customPromotedPropertyName != null) &&
            (customPromotedPropertyName.Length >= 100))
            {
                strList.Add("Invalid property Name");
            }

            if ((customPromotedPropertyValue != null) &&
          (customPromotedPropertyValue.Length >= 256))
            {
                strList.Add("Invalid property value");
            }
            if (strList.Count > 0)
            {
                enumerator = strList.GetEnumerator();
            }

            return enumerator;
        }

        #endregion
    }

}
