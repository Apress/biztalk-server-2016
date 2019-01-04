
#pragma warning disable 162

namespace WebServiceBookOrders
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "WebBookOrders",
        new System.Type[]{
            typeof(WebServiceBookOrders.__messagetype_WebServiceBookOrders_BookOrderRequest), 
            typeof(WebServiceBookOrders.__messagetype_WebServiceBookOrders_BookOrderResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class PortType_Port_WebBookOrders : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_Port_WebBookOrders(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_Port_WebBookOrders(PortType_Port_WebBookOrders p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_Port_WebBookOrders p = new PortType_Port_WebBookOrders(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo WebBookOrders = new Microsoft.XLANGs.Core.OperationInfo
        (
            "WebBookOrders",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(PortType_Port_WebBookOrders),
            typeof(__messagetype_WebServiceBookOrders_BookOrderRequest),
            typeof(__messagetype_WebServiceBookOrders_BookOrderResponse),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "WebBookOrders" ] = WebBookOrders;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 182 "C:\APRESS\Chapter8\WebServiceBookOrders\WebServiceBookOrders\WebServiceBookOrders\orcBookOrders.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "Port_WebBookOrders", "WebBookOrders", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        },
        new System.Type[] {
            typeof(WebServiceBookOrders.PortType_Port_WebBookOrders)
        },
        new System.String[] {
            "Port_WebBookOrders"
        },
        new System.Type[] {
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class orcBookOrders : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(orcBookOrders));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static orcBookOrders()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __orcBookOrders_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public orcBookOrders(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "orcBookOrders", tracker)
        {
            ConstructorHelper();
        }

        public orcBookOrders(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "orcBookOrders")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>7f999983-9f94-4c7a-be8c-ed4e0af29940</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>57c832a7-816b-4320-8b52-fe023b1a2c3b</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_Request</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>5824dce4-9ffa-42bd-af2a-c8262f9bd762</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Decide_VIP</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>428140e5-53a3-451c-bfa5-e0add96d23d8</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>VipRequest</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>b69a3e9a-2777-4896-9849-ec6174afe4f8</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructVIPMessage</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>e3307051-a2ab-4ebb-99e2-b61698a9613e</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>mapVIP</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>91ca953b-22ca-4442-8eb7-542591281117</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>a31e36e2-6707-4130-8a65-557c470625a0</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>f03f18c8-4205-4bfa-be44-13c200f776bb</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>9e617551-5a7e-46f7-88e5-ba7f5ba0927e</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>0a61034e-33ba-4035-a0d7-bbdc261bd3e0</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructNonVIPMessage</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>aa8971fb-7ed1-472f-8326-ba1ed83bc48b</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>mapNonVIP</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>08114444-f0e6-4c45-8c17-d0aa5daad097</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>0cbebe49-eaf3-4c51-beb0-3dce3ecead72</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>d9482ec2-bbae-4a9e-9f4a-97adb51386a2</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>6ca87402-238f-4572-b760-23b70748bb2e</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_Response</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'orcBookOrders'</ActionName><IsAtomic>0</IsAtomic><Line>182</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>191</Line><Position>22</Position><ShapeID>'57c832a7-816b-4320-8b52-fe023b1a2c3b'</ShapeID>
<Messages>
	<MsgInfo><name>Message_Request</name><part>part</part><schema>WebServiceBookOrders.BookOrderRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>193</Line><Position>13</Position><ShapeID>'5824dce4-9ffa-42bd-af2a-c8262f9bd762'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>196</Line><Position>17</Position><ShapeID>'b69a3e9a-2777-4896-9849-ec6174afe4f8'</ShapeID>
<Messages>
	<MsgInfo><name>Message_Response</name><part>part</part><schema>WebServiceBookOrders.BookOrderResponse</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>Message_Request</name><part>part</part><schema>WebServiceBookOrders.BookOrderRequest</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>205</Line><Position>17</Position><ShapeID>'0a61034e-33ba-4035-a0d7-bbdc261bd3e0'</ShapeID>
<Messages>
	<MsgInfo><name>Message_Response</name><part>part</part><schema>WebServiceBookOrders.BookOrderResponse</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>Message_Request</name><part>part</part><schema>WebServiceBookOrders.BookOrderRequest</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>212</Line><Position>13</Position><ShapeID>'6ca87402-238f-4572-b760-23b70748bb2e'</ShapeID>
<Messages>
	<MsgInfo><name>Message_Response</name><part>part</part><schema>WebServiceBookOrders.BookOrderResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='11e43849-68bd-48f3-95d9-0aa6147b46ec' LowerBound='1.1' HigherBound='46.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='WebServiceBookOrders' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='73741dc3-c277-4196-a0e5-dd58a68a205c' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_Port_WebBookOrders' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='a299d0b6-2762-4081-bada-1eae8f3ce6b2' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='WebBookOrders' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='e4d0dde3-9447-45f3-8d99-bfb5bfef6034' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.29'>
                    <om:Property Name='Ref' Value='WebServiceBookOrders.BookOrderRequest' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='77e57670-7484-4002-8c43-6355989874e6' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='8.31' HigherBound='8.48'>
                    <om:Property Name='Ref' Value='WebServiceBookOrders.BookOrderResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='f9752a3f-7f5c-48bc-a843-96beb0b21028' ParentLink='Module_ServiceDeclaration' LowerBound='11.1' HigherBound='45.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='orcBookOrders' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='MessageDeclaration' OID='980afc7b-edf7-484d-9e48-79708ee97b0c' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='16.1' HigherBound='17.1'>
                <om:Property Name='Type' Value='WebServiceBookOrders.BookOrderRequest' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Message_Request' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='9d0bbc06-48cd-4472-9587-9610d77fd698' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='17.1' HigherBound='18.1'>
                <om:Property Name='Type' Value='WebServiceBookOrders.BookOrderResponse' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Message_Response' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='7f999983-9f94-4c7a-be8c-ed4e0af29940' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='57c832a7-816b-4320-8b52-fe023b1a2c3b' ParentLink='ServiceBody_Statement' LowerBound='20.1' HigherBound='22.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='Port_WebBookOrders' />
                    <om:Property Name='MessageName' Value='Message_Request' />
                    <om:Property Name='OperationName' Value='WebBookOrders' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Decision' OID='5824dce4-9ffa-42bd-af2a-c8262f9bd762' ParentLink='ServiceBody_Statement' LowerBound='22.1' HigherBound='41.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Decide_VIP' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='DecisionBranch' OID='428140e5-53a3-451c-bfa5-e0add96d23d8' ParentLink='ReallyComplexStatement_Branch' LowerBound='23.13' HigherBound='32.1'>
                        <om:Property Name='Expression' Value='Message_Request.isVIP ==true' />
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='VipRequest' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Construct' OID='b69a3e9a-2777-4896-9849-ec6174afe4f8' ParentLink='ComplexStatement_Statement' LowerBound='25.1' HigherBound='31.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ConstructVIPMessage' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Transform' OID='e3307051-a2ab-4ebb-99e2-b61698a9613e' ParentLink='ComplexStatement_Statement' LowerBound='28.1' HigherBound='30.1'>
                                <om:Property Name='ClassName' Value='WebServiceBookOrders.mapCreateWebResponseVIPCustomer' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='mapVIP' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessagePartRef' OID='91ca953b-22ca-4442-8eb7-542591281117' ParentLink='Transform_InputMessagePartRef' LowerBound='29.106' HigherBound='29.121'>
                                    <om:Property Name='MessageRef' Value='Message_Request' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_1' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessagePartRef' OID='a31e36e2-6707-4130-8a65-557c470625a0' ParentLink='Transform_OutputMessagePartRef' LowerBound='29.32' HigherBound='29.48'>
                                    <om:Property Name='MessageRef' Value='Message_Response' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_2' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='MessageRef' OID='f03f18c8-4205-4bfa-be44-13c200f776bb' ParentLink='Construct_MessageRef' LowerBound='26.27' HigherBound='26.43'>
                                <om:Property Name='Ref' Value='Message_Response' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='DecisionBranch' OID='9e617551-5a7e-46f7-88e5-ba7f5ba0927e' ParentLink='ReallyComplexStatement_Branch'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Else' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Construct' OID='0a61034e-33ba-4035-a0d7-bbdc261bd3e0' ParentLink='ComplexStatement_Statement' LowerBound='34.1' HigherBound='40.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ConstructNonVIPMessage' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Transform' OID='aa8971fb-7ed1-472f-8326-ba1ed83bc48b' ParentLink='ComplexStatement_Statement' LowerBound='37.1' HigherBound='39.1'>
                                <om:Property Name='ClassName' Value='WebServiceBookOrders.mapCreateWebResponseNonVIPCustomer' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='mapNonVIP' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='MessagePartRef' OID='08114444-f0e6-4c45-8c17-d0aa5daad097' ParentLink='Transform_InputMessagePartRef' LowerBound='38.109' HigherBound='38.124'>
                                    <om:Property Name='MessageRef' Value='Message_Request' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_3' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessagePartRef' OID='0cbebe49-eaf3-4c51-beb0-3dce3ecead72' ParentLink='Transform_OutputMessagePartRef' LowerBound='38.32' HigherBound='38.48'>
                                    <om:Property Name='MessageRef' Value='Message_Response' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_4' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='MessageRef' OID='d9482ec2-bbae-4a9e-9f4a-97adb51386a2' ParentLink='Construct_MessageRef' LowerBound='35.27' HigherBound='35.43'>
                                <om:Property Name='Ref' Value='Message_Response' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='6ca87402-238f-4572-b760-23b70748bb2e' ParentLink='ServiceBody_Statement' LowerBound='41.1' HigherBound='43.1'>
                    <om:Property Name='PortName' Value='Port_WebBookOrders' />
                    <om:Property Name='MessageName' Value='Message_Response' />
                    <om:Property Name='OperationName' Value='WebBookOrders' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_Response' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='ae4e8146-1678-43ae-9be5-0da8ad3015e2' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='14.1' HigherBound='16.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='WebServiceBookOrders.PortType_Port_WebBookOrders' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_WebBookOrders' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='c7e1ea0d-5a10-4757-b2bf-da5b7a7ac61e' ParentLink='PortDeclaration_CLRAttribute' LowerBound='14.1' HigherBound='15.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __orcBookOrders_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __orcBookOrders_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "orcBookOrders")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                orcBookOrders __svc__ = (orcBookOrders)_service;
                __orcBookOrders_root_0 __ctx0__ = (__orcBookOrders_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.Port_WebBookOrders != null)
                {
                    __svc__.Port_WebBookOrders.Close(this, null);
                    __svc__.Port_WebBookOrders = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __orcBookOrders_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __orcBookOrders_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "orcBookOrders")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                orcBookOrders __svc__ = (orcBookOrders)_service;
                __orcBookOrders_1 __ctx1__ = (__orcBookOrders_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__Message_Request != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Message_Request);
                    __ctx1__.__Message_Request = null;
                }
                if (__ctx1__ != null && __ctx1__.__Message_Response != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Message_Response);
                    __ctx1__.__Message_Response = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("Message_Request")]
            public __messagetype_WebServiceBookOrders_BookOrderRequest __Message_Request;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Message_Response")]
            public __messagetype_WebServiceBookOrders_BookOrderResponse __Message_Response;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_WebBookOrders")]
        internal PortType_Port_WebBookOrders Port_WebBookOrders;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_Port_WebBookOrders.WebBookOrders},
                                               typeof(orcBookOrders).GetField("Port_WebBookOrders", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(orcBookOrders), "Port_WebBookOrders"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "57c832a7-816b-4320-8b52-fe023b1a2c3b", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "57c832a7-816b-4320-8b52-fe023b1a2c3b", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "5824dce4-9ffa-42bd-af2a-c8262f9bd762", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "b69a3e9a-2777-4896-9849-ec6174afe4f8", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "b69a3e9a-2777-4896-9849-ec6174afe4f8", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "0a61034e-33ba-4035-a0d7-bbdc261bd3e0", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "0a61034e-33ba-4035-a0d7-bbdc261bd3e0", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "5824dce4-9ffa-42bd-af2a-c8262f9bd762", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "6ca87402-238f-4572-b760-23b70748bb2e", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "6ca87402-238f-4572-b760-23b70748bb2e", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,11,11,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,3,3,4,4,5,3,6,6,7,8,9,9,9,10,11,11,11,11,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __orcBookOrders_root_0 __ctx0__ = (__orcBookOrders_root_0)_stateMgrs[0];
            __orcBookOrders_1 __ctx1__ = (__orcBookOrders_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                Port_WebBookOrders = new PortType_Port_WebBookOrders(0, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], Port_WebBookOrders, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __orcBookOrders_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __orcBookOrders_root_0 __ctx0__ = (__orcBookOrders_root_0)_stateMgrs[0];
            __orcBookOrders_1 __ctx1__ = (__orcBookOrders_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!Port_WebBookOrders.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__Message_Request != null)
                    __ctx1__.UnrefMessage(__ctx1__.__Message_Request);
                __ctx1__.__Message_Request = new __messagetype_WebServiceBookOrders_BookOrderRequest("Message_Request", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__Message_Request);
                Port_WebBookOrders.ReceiveMessage(0, __msgEnv__, __ctx1__.__Message_Request, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__Message_Request);
                    __edata.PortName = @"Port_WebBookOrders";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                __condition__ = (System.Boolean)__ctx1__.__Message_Request.part.GetDistinguishedField("isVIP");
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 11;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                {
                    __messagetype_WebServiceBookOrders_BookOrderResponse __Message_Response = new __messagetype_WebServiceBookOrders_BookOrderResponse("Message_Response", __ctx1__);

                    ApplyTransform(typeof(WebServiceBookOrders.mapCreateWebResponseVIPCustomer), new object[] {__Message_Response.part}, new object[] {__ctx1__.__Message_Request.part});

                    if (__ctx1__.__Message_Response != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Message_Response);
                    __ctx1__.__Message_Response = __Message_Response;
                    __ctx1__.RefMessage(__ctx1__.__Message_Response);
                }
                __ctx1__.__Message_Response.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Message_Response);
                    __edata.Messages.Add(__ctx1__.__Message_Request);
                    Tracker.FireEvent(__eventLocations[5],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                {
                    __messagetype_WebServiceBookOrders_BookOrderResponse __Message_Response = new __messagetype_WebServiceBookOrders_BookOrderResponse("Message_Response", __ctx1__);

                    ApplyTransform(typeof(WebServiceBookOrders.mapCreateWebResponseNonVIPCustomer), new object[] {__Message_Response.part}, new object[] {__ctx1__.__Message_Request.part});

                    if (__ctx1__.__Message_Response != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Message_Response);
                    __ctx1__.__Message_Response = __Message_Response;
                    __ctx1__.RefMessage(__ctx1__.__Message_Response);
                }
                __ctx1__.__Message_Response.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Message_Response);
                    __edata.Messages.Add(__ctx1__.__Message_Request);
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null && __ctx1__.__Message_Request != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Message_Request);
                    __ctx1__.__Message_Request = null;
                }
                Tracker.FireEvent(__eventLocations[8],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_WebBookOrders.SendMessage(0, __ctx1__.__Message_Response, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (Port_WebBookOrders != null)
                {
                    Port_WebBookOrders.Close(__ctx1__, __seg__);
                    Port_WebBookOrders = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingResp) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingResp;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Message_Response);
                    __edata.PortName = @"Port_WebBookOrders";
                    Tracker.FireEvent(__eventLocations[10],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Message_Response != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Message_Response);
                    __ctx1__.__Message_Response = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 22;
            case 22:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __WebServiceBookOrders_BookOrderRequest__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static WebServiceBookOrders.BookOrderRequest _schema = new WebServiceBookOrders.BookOrderRequest();

        public __WebServiceBookOrders_BookOrderRequest__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "WebServiceBookOrders.BookOrderRequest",
        new System.Type[]{
            typeof(WebServiceBookOrders.BookOrderRequest)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__WebServiceBookOrders_BookOrderRequest__)
        },
        0,
        @"http://WebServiceBookOrders.BookOrderRequest#BookOrderRequest"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_WebServiceBookOrders_BookOrderRequest : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __WebServiceBookOrders_BookOrderRequest__ part;

        private void __CreatePartWrappers()
        {
            part = new __WebServiceBookOrders_BookOrderRequest__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_WebServiceBookOrders_BookOrderRequest(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __WebServiceBookOrders_BookOrderResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static WebServiceBookOrders.BookOrderResponse _schema = new WebServiceBookOrders.BookOrderResponse();

        public __WebServiceBookOrders_BookOrderResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "WebServiceBookOrders.BookOrderResponse",
        new System.Type[]{
            typeof(WebServiceBookOrders.BookOrderResponse)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__WebServiceBookOrders_BookOrderResponse__)
        },
        0,
        @"http://WebServiceBookOrders.BookOrderResponse#BookOrderResponse"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_WebServiceBookOrders_BookOrderResponse : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __WebServiceBookOrders_BookOrderResponse__ part;

        private void __CreatePartWrappers()
        {
            part = new __WebServiceBookOrders_BookOrderResponse__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_WebServiceBookOrders_BookOrderResponse(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
