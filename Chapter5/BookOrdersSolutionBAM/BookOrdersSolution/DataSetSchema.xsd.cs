namespace BookOrdersSolution {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"DataSet", @"ArrayOfDataSet"})]
    public sealed class DataSetSchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://schemas.datacontract.org/2004/07/System.Data"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.datacontract.org/2004/07/System.Data"" xmlns=""http://www.w3.org/2001/XMLSchema"">
  <annotation>
    <appinfo>
      <fileNameHint xmlns=""http://schemas.microsoft.com/servicemodel/adapters/metadata/xsd"">DataSetSchema</fileNameHint>
    </appinfo>
  </annotation>
  <complexType name=""DataSet"">
    <annotation>
      <appinfo>
        <ActualType Name=""DataSet"" Namespace=""http://schemas.datacontract.org/2004/07/System.Data"" xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">
        </ActualType>
      </appinfo>
    </annotation>
    <sequence>
      <any />
      <any />
    </sequence>
  </complexType>
  <element name=""DataSet"" nillable=""true"" type=""tns:DataSet"" />
  <complexType name=""ArrayOfDataSet"">
    <sequence>
      <element minOccurs=""0"" maxOccurs=""unbounded"" name=""DataSet"" type=""tns:DataSet"" />
    </sequence>
  </complexType>
  <element name=""ArrayOfDataSet"" nillable=""true"" type=""tns:ArrayOfDataSet"" />
</schema>";
        
        public DataSetSchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "DataSet";
                _RootElements[1] = "ArrayOfDataSet";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/System.Data",@"DataSet")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DataSet"})]
        public sealed class DataSet : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DataSet() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DataSet";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/System.Data",@"ArrayOfDataSet")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfDataSet"})]
        public sealed class ArrayOfDataSet : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfDataSet() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfDataSet";
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
