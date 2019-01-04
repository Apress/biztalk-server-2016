namespace BookOrdersSolution {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BookOrdersSolution.schemas.IncomingBookOrders", typeof(global::BookOrdersSolution.schemas.IncomingBookOrders))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BookOrdersSolution.Procedure_dbo+spIsTransactionApproved", typeof(global::BookOrdersSolution.Procedure_dbo.spIsTransactionApproved))]
    public sealed class Map_IncomingBookOrders_To__ApprovaRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo"" xmlns:s0=""http://BookOrdersSolution.IncomingBookOrders"" xmlns:ns3=""http://schemas.datacontract.org/2004/07/System.Data"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:IncomingBookOrders"" />
  </xsl:template>
  <xsl:template match=""/s0:IncomingBookOrders"">
    <ns0:spIsTransactionApproved>
      <ns0:transactionCode>
        <xsl:value-of select=""OrderID/text()"" />
      </ns0:transactionCode>
    </ns0:spIsTransactionApproved>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BookOrdersSolution.schemas.IncomingBookOrders";
        
        private const global::BookOrdersSolution.schemas.IncomingBookOrders _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BookOrdersSolution.Procedure_dbo+spIsTransactionApproved";
        
        private const global::BookOrdersSolution.Procedure_dbo.spIsTransactionApproved _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"BookOrdersSolution.schemas.IncomingBookOrders";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BookOrdersSolution.Procedure_dbo+spIsTransactionApproved";
                return _TrgSchemas;
            }
        }
    }
}
