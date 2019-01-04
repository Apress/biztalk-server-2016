namespace BizTalkUnitTestingFeatureProject {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkUnitTestingFeatureProject.IncomingBookOrders", typeof(global::BizTalkUnitTestingFeatureProject.IncomingBookOrders))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkUnitTestingFeatureProject.CRMIncomingBookOrders", typeof(global::BizTalkUnitTestingFeatureProject.CRMIncomingBookOrders))]
    public sealed class Map_IncomingBookOrders_To_CRMIncomingBookOrders : global::Microsoft.BizTalk.TestTools.Mapper.TestableMapBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://BizTalkUnitTestingFeatureProject.CRMIncomingBookOrders"" xmlns:s0=""http://BizTalkUnitTestingFeatureProject.IncomingBookOrders"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:IncomingBookOrders"" />
  </xsl:template>
  <xsl:template match=""/s0:IncomingBookOrders"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringUpperCase(string(OrderComments/text()))"" />
    <ns0:CRMData>
      <CRMTransactionCode>
        <xsl:value-of select=""OrderID/text()"" />
      </CRMTransactionCode>
      <CRMTransactionDate>
        <xsl:value-of select=""OrderDate/text()"" />
      </CRMTransactionDate>
      <CRMObservations>
        <xsl:value-of select=""$var:v1"" />
      </CRMObservations>
      <xsl:for-each select=""RequestedBooks"">
        <xsl:variable name=""var:v2"" select=""userCSharp:StringUpperCase(string(BookTitile/text()))"" />
        <CRMChildItems>
          <CRMChildCode>
            <xsl:value-of select=""BookID/text()"" />
          </CRMChildCode>
          <CRMChildDescription>
            <xsl:value-of select=""$var:v2"" />
          </CRMChildDescription>
          <CRMChildUnits>
            <xsl:value-of select=""BookPrice/text()"" />
          </CRMChildUnits>
          <CRMChildCost>
            <xsl:value-of select=""UnitsRequested/text()"" />
          </CRMChildCost>
        </CRMChildItems>
      </xsl:for-each>
    </ns0:CRMData>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringUpperCase(string str)
{
	if (str == null)
	{
		return """";
	}
	return str.ToUpper(System.Globalization.CultureInfo.InvariantCulture);
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BizTalkUnitTestingFeatureProject.IncomingBookOrders";
        
        private const global::BizTalkUnitTestingFeatureProject.IncomingBookOrders _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BizTalkUnitTestingFeatureProject.CRMIncomingBookOrders";
        
        private const global::BizTalkUnitTestingFeatureProject.CRMIncomingBookOrders _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"BizTalkUnitTestingFeatureProject.IncomingBookOrders";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BizTalkUnitTestingFeatureProject.CRMIncomingBookOrders";
                return _TrgSchemas;
            }
        }
    }
}
