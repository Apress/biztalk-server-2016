namespace BookOrdersSolution.schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BookOrdersSolution.CRMIncomingBookOrders",@"CRMData")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CRMData"})]
    public sealed class CRMIncomingBookOrders : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BookOrdersSolution.CRMIncomingBookOrders"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://BookOrdersSolution.CRMIncomingBookOrders"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""CRMData"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""CRMTransactionCode"" type=""xs:string"" />
        <xs:element name=""CRMTransactionDate"" type=""xs:string"" />
        <xs:element name=""CRMObservations"" type=""xs:string"" />
        <xs:element name=""CRMChildItems"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""CRMChildCode"" type=""xs:string"" />
              <xs:element name=""CRMChildDescription"" type=""xs:string"" />
              <xs:element name=""CRMChildUnits"" type=""xs:string"" />
              <xs:element name=""CRMChildCost"" type=""xs:string"" />
              <xs:element name=""CRMTotalAmount"" type=""xs:string"" />
              <xs:element name=""CRMCommentsAmmount"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public CRMIncomingBookOrders() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "CRMData";
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
