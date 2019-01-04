namespace BookOrdersSolution.maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BookOrdersSolution.schemas.IncomingBookOrders", typeof(global::BookOrdersSolution.schemas.IncomingBookOrders))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BookOrdersSolution.schemas.CRMIncomingBookOrders", typeof(global::BookOrdersSolution.schemas.CRMIncomingBookOrders))]
    public sealed class Map_IncomingMessage_To_CRM_CongratuleMessage : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 ScriptNS0 ScriptNS1"" version=""1.0"" xmlns:ns0=""http://BookOrdersSolution.CRMIncomingBookOrders"" xmlns:s0=""http://BookOrdersSolution.IncomingBookOrders"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" xmlns:ScriptNS1=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS1"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:IncomingBookOrders"" />
  </xsl:template>
  <xsl:template match=""/s0:IncomingBookOrders"">
    <ns0:CRMData>
      <CRMTransactionCode>
        <xsl:value-of select=""OrderID/text()"" />
      </CRMTransactionCode>
      <CRMTransactionDate>
        <xsl:value-of select=""OrderDate/text()"" />
      </CRMTransactionDate>
      <xsl:variable name=""var:v1"" select=""ScriptNS0:Read(&quot;BoookOrdersApplication&quot; , &quot;CongratulationMessage&quot;)"" />
      <CRMObservations>
        <xsl:value-of select=""$var:v1"" />
      </CRMObservations>
      <xsl:for-each select=""RequestedBooks"">
        <CRMChildItems>
          <CRMChildCode>
            <xsl:value-of select=""BookID/text()"" />
          </CRMChildCode>
          <CRMChildDescription>
            <xsl:value-of select=""BookTitile/text()"" />
          </CRMChildDescription>
          <CRMChildUnits>
            <xsl:value-of select=""UnitsRequested/text()"" />
          </CRMChildUnits>
          <CRMChildCost>
            <xsl:value-of select=""BookPrice/text()"" />
          </CRMChildCost>
          <xsl:variable name=""var:v2"" select=""ScriptNS1:returnTotalAmmount(string(BookPrice/text()) , string(UnitsRequested/text()))"" />
          <CRMTotalAmount>
            <xsl:value-of select=""$var:v2"" />
          </CRMTotalAmount>
          <CRMCommentsAmmount>
            <xsl:text>Default Comment</xsl:text>
          </CRMCommentsAmmount>
        </CRMChildItems>
      </xsl:for-each>
    </ns0:CRMData>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""SSOClientHelper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=ea25db6fbb69be69"" ClassName=""SSOClientHelper.SSOClientHelper"" />
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS1"" AssemblyName=""BooksOrderHelper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=6e966f95256380f3"" ClassName=""BooksOrderHelper.BooksOrderHelper"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"BookOrdersSolution.schemas.IncomingBookOrders";
        
        private const global::BookOrdersSolution.schemas.IncomingBookOrders _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BookOrdersSolution.schemas.CRMIncomingBookOrders";
        
        private const global::BookOrdersSolution.schemas.CRMIncomingBookOrders _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"BookOrdersSolution.schemas.CRMIncomingBookOrders";
                return _TrgSchemas;
            }
        }
    }
}
