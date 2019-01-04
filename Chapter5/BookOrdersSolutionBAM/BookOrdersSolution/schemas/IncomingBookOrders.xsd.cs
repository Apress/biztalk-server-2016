namespace BookOrdersSolution.schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BookOrdersSolution.IncomingBookOrders",@"IncomingBookOrders")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::BookOrdersSolution.PropertySchema.isVIPCustomer), XPath = @"/*[local-name()='IncomingBookOrders' and namespace-uri()='http://BookOrdersSolution.IncomingBookOrders']/*[local-name()='isVIPCustomer' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"IncomingBookOrders"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BookOrdersSolution.PropertySchema.PropertySchema", typeof(global::BookOrdersSolution.PropertySchema.PropertySchema))]
    public sealed class IncomingBookOrders : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BookOrdersSolution.IncomingBookOrders"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://BookOrdersSolution.PropertySchema"" targetNamespace=""http://BookOrdersSolution.IncomingBookOrders"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://BookOrdersSolution.PropertySchema"" location=""BookOrdersSolution.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""IncomingBookOrders"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:isVIPCustomer"" xpath=""/*[local-name()='IncomingBookOrders' and namespace-uri()='http://BookOrdersSolution.IncomingBookOrders']/*[local-name()='isVIPCustomer' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" name=""OrderID"" type=""xs:string"" />
        <xs:element minOccurs=""1"" name=""OrderDate"" type=""xs:string"" />
        <xs:element minOccurs=""1"" name=""OrderComments"" type=""xs:string"" />
        <xs:element name=""isVIPCustomer"" type=""xs:string"" />
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
