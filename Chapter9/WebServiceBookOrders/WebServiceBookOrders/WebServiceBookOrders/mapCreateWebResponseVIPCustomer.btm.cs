namespace WebServiceBookOrders {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"WebServiceBookOrders.BookOrderRequest", typeof(global::WebServiceBookOrders.BookOrderRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"WebServiceBookOrders.BookOrderResponse", typeof(global::WebServiceBookOrders.BookOrderResponse))]
    public sealed class mapCreateWebResponseVIPCustomer : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://WebServiceBookOrders.BookOrderResponse"" xmlns:s0=""http://WebServiceBookOrders.BookOrderRequest"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:BookOrderRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:BookOrderRequest"">
    <ns0:BookOrderResponse>
      <customerID>
        <xsl:value-of select=""CustomerId/text()"" />
      </customerID>
      <OutputMessage>
        <xsl:text>The order is from a VIP customer</xsl:text>
      </OutputMessage>
      <orderID>
        <xsl:value-of select=""OrderId/text()"" />
      </orderID>
    </ns0:BookOrderResponse>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"WebServiceBookOrders.BookOrderRequest";
        
        private const global::WebServiceBookOrders.BookOrderRequest _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"WebServiceBookOrders.BookOrderResponse";
        
        private const global::WebServiceBookOrders.BookOrderResponse _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"WebServiceBookOrders.BookOrderRequest";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"WebServiceBookOrders.BookOrderResponse";
                return _TrgSchemas;
            }
        }
    }
}
