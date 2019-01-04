namespace BookPromotedProperties {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BookPromotedProperties.BookPromotedPropertiesSchema",@"BookPromotedProperties")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::BookPromotedProperties.PropertySchema.BookTrackId), XPath = @"/*[local-name()='BookPromotedProperties' and namespace-uri()='http://BookPromotedProperties.BookPromotedPropertiesSchema']/*[local-name()='BookTrackId' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::BookPromotedProperties.PropertySchema.BookSystemId), XPath = @"/*[local-name()='BookPromotedProperties' and namespace-uri()='http://BookPromotedProperties.BookPromotedPropertiesSchema']/*[local-name()='BookSystemId' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"BookPromotedProperties"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BookPromotedProperties.PropertySchema.PropertySchema", typeof(global::BookPromotedProperties.PropertySchema.PropertySchema))]
    public sealed class BookPromotedPropertiesSchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BookPromotedProperties.BookPromotedPropertiesSchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://BookPromotedProperties.PropertySchema"" targetNamespace=""http://BookPromotedProperties.BookPromotedPropertiesSchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://BookPromotedProperties.PropertySchema"" location=""BookPromotedProperties.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""BookPromotedProperties"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:BookTrackId"" xpath=""/*[local-name()='BookPromotedProperties' and namespace-uri()='http://BookPromotedProperties.BookPromotedPropertiesSchema']/*[local-name()='BookTrackId' and namespace-uri()='']"" />
          <b:property name=""ns0:BookSystemId"" xpath=""/*[local-name()='BookPromotedProperties' and namespace-uri()='http://BookPromotedProperties.BookPromotedPropertiesSchema']/*[local-name()='BookSystemId' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""BookTrackId"" type=""xs:string"" />
        <xs:element name=""BookSystemId"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public BookPromotedPropertiesSchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "BookPromotedProperties";
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
