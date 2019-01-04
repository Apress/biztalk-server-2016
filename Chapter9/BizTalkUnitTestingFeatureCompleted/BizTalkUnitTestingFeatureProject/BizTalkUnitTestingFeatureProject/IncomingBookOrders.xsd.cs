namespace BizTalkUnitTestingFeatureProject {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BizTalkUnitTestingFeatureProject.IncomingBookOrders",@"IncomingBookOrders")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"IncomingBookOrders"})]
    public sealed class IncomingBookOrders : Microsoft.BizTalk.TestTools.Schema.TestableSchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BizTalkUnitTestingFeatureProject.IncomingBookOrders"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://BizTalkUnitTestingFeatureProject.IncomingBookOrders"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""IncomingBookOrders"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" name=""OrderID"" type=""xs:string"" />
        <xs:element minOccurs=""1"" name=""OrderDate"" type=""xs:string"" />
        <xs:element minOccurs=""1"" name=""OrderComments"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""RequestedBooks"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""1"" name=""BookID"" type=""xs:string"" />
              <xs:element minOccurs=""1"" name=""BookTitile"" type=""xs:string"" />
              <xs:element minOccurs=""1"" name=""BookPrice"" type=""xs:string"" />
              <xs:element minOccurs=""1"" name=""UnitsRequested"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public IncomingBookOrders() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "IncomingBookOrders";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
