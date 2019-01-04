namespace CustomPipelineTesting
{
    using System;
    using System.Collections.Generic;
    using Microsoft.BizTalk.PipelineOM;
    using Microsoft.BizTalk.Component;
    using Microsoft.BizTalk.Component.Interop;
    
    
    public sealed class CustomPipelineTesting : Microsoft.BizTalk.PipelineOM.ReceivePipeline
    {
        
        private const string _strPipeline = "<?xml version=\"1.0\" encoding=\"utf-16\"?><Document xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instanc"+
"e\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" MajorVersion=\"1\" MinorVersion=\"0\">  <Description /> "+
" <CategoryId>f66b9f5e-43ff-4f5f-ba46-885348ae1b4e</CategoryId>  <FriendlyName>Receive</FriendlyName>"+
"  <Stages>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"1\" Name=\"Decode\" minOccurs=\""+
"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4103-4cce-4536-83fa-4a5040674ad6\" />      <Component"+
"s />    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"2\" Name=\"Disassemble\" "+
"minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"FirstMatch\" stageId=\"9d0e4105-4cce-4536-83fa-4a5040674ad6\" "+
"/>      <Components />    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"3\" N"+
"ame=\"Validate\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e410d-4cce-4536-83fa-4a5040"+
"674ad6\" />      <Components>        <Component>          <Name>Microsoft.BizTalk.Pipelines.CustomCom"+
"ponent.PropertyGeneratorPipeline.PropertyGeneratorPipeline,PropertyGeneratorPipeline, Version=1.0.0."+
"0, Culture=neutral, PublicKeyToken=acca230a5218e017</Name>          <ComponentName>Property Generato"+
"r Component</ComponentName>          <Description>Custom Pipeline Component</Description>          <"+
"Version>1.0</Version>          <Properties>            <Property Name=\"NameSpace\" />            <Pro"+
"perty Name=\"PropertyName\" />            <Property Name=\"PropertyValue\" />          </Properties>    "+
"      <CachedDisplayName>Property Generator Component</CachedDisplayName>          <CachedIsManaged>"+
"true</CachedIsManaged>        </Component>      </Components>    </Stage>    <Stage>      <PolicyFil"+
"eStage _locAttrData=\"Name\" _locID=\"4\" Name=\"ResolveParty\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"A"+
"ll\" stageId=\"9d0e410e-4cce-4536-83fa-4a5040674ad6\" />      <Components />    </Stage>  </Stages></Do"+
"cument>";
        
        private const string _versionDependentGuid = "72b8ef93-f716-4a08-b6f1-f6e6a2a81423";
        
        public CustomPipelineTesting()
        {
            Microsoft.BizTalk.PipelineOM.Stage stage = this.AddStage(new System.Guid("9d0e410d-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
            IBaseComponent comp0 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.Pipelines.CustomComponent.PropertyGeneratorPipeline.PropertyGeneratorPipeline,PropertyGeneratorPipeline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=acca230a5218e017");;
            if (comp0 is IPersistPropertyBag)
            {
                string comp0XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"NameSpace\" />  "+
"  <Property Name=\"PropertyName\" />    <Property Name=\"PropertyValue\" />  </Properties></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp0XmlProperties);;
                ((IPersistPropertyBag)(comp0)).Load(pb, 0);
            }
            this.AddComponent(stage, comp0);
        }
        
        public override string XmlContent
        {
            get
            {
                return _strPipeline;
            }
        }
        
        public override System.Guid VersionDependentGuid
        {
            get
            {
                return new System.Guid(_versionDependentGuid);
            }
        }
    }
}
