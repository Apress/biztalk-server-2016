namespace BookOrdersSolution {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::BookOrdersSolution.PropertySchema.transactionCode), XPath = @"/*[local-name()='spIsTransactionApproved' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo']/*[local-name()='transactionCode' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::BookOrdersSolution.PropertySchema.Approved), XPath = @"/*[local-name()='spIsTransactionApprovedResponse' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo']/*[local-name()='Approved' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo']", XsdType = @"boolean")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"spIsTransactionApproved", @"spIsTransactionApprovedResponse"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BookOrdersSolution.DataSetSchema", typeof(global::BookOrdersSolution.DataSetSchema))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BookOrdersSolution.PropertySchema.PropertySchema", typeof(global::BookOrdersSolution.PropertySchema.PropertySchema))]
    public sealed class Procedure_dbo : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://BookOrdersSolution.PropertySchema"" xmlns:ns3=""http://schemas.datacontract.org/2004/07/System.Data"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""BookOrdersSolution.DataSetSchema"" namespace=""http://schemas.datacontract.org/2004/07/System.Data"" />
  <xs:annotation>
    <xs:appinfo>
      <fileNameHint xmlns=""http://schemas.microsoft.com/servicemodel/adapters/metadata/xsd"">Procedure.dbo</fileNameHint>
      <b:references>
        <b:reference targetNamespace=""http://schemas.datacontract.org/2004/07/System.Data"" />
      </b:references>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://BookOrdersSolution.PropertySchema"" location=""BookOrdersSolution.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""spIsTransactionApproved"">
    <xs:annotation>
      <xs:documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">Procedure/dbo/spIsTransactionApproved</doc:action>
      </xs:documentation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:transactionCode"" xpath=""/*[local-name()='spIsTransactionApproved' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo']/*[local-name()='transactionCode' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""transactionCode"" nillable=""true"">
          <xs:simpleType>
            <xs:restriction base=""xs:string"">
              <xs:maxLength value=""10"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Approved"" nillable=""true"" type=""xs:boolean"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""spIsTransactionApprovedResponse"">
    <xs:annotation>
      <xs:documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">Procedure/dbo/spIsTransactionApproved/response</doc:action>
      </xs:documentation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:Approved"" xpath=""/*[local-name()='spIsTransactionApprovedResponse' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo']/*[local-name()='Approved' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""spIsTransactionApprovedResult"" nillable=""true"" type=""ns3:ArrayOfDataSet"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ReturnValue"" type=""xs:int"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Approved"" nillable=""true"" type=""xs:boolean"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Procedure_dbo() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "spIsTransactionApproved";
                _RootElements[1] = "spIsTransactionApprovedResponse";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo",@"spIsTransactionApproved")]
        [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::BookOrdersSolution.PropertySchema.transactionCode), XPath = @"/*[local-name()='spIsTransactionApproved' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo']/*[local-name()='transactionCode' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo']", XsdType = @"string")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"spIsTransactionApproved"})]
        public sealed class spIsTransactionApproved : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public spIsTransactionApproved() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "spIsTransactionApproved";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo",@"spIsTransactionApprovedResponse")]
        [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::BookOrdersSolution.PropertySchema.Approved), XPath = @"/*[local-name()='spIsTransactionApprovedResponse' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo']/*[local-name()='Approved' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo']", XsdType = @"boolean")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"spIsTransactionApprovedResponse"})]
        public sealed class spIsTransactionApprovedResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public spIsTransactionApprovedResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "spIsTransactionApprovedResponse";
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
}
