
#pragma warning disable 162

namespace BookOrdersSolution
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_BookOrders",
        new System.Type[]{
            typeof(BookOrdersSolution.__messagetype_BookOrdersSolution_schemas_IncomingBookOrders)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_IN : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_IN(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_IN(PortType_IN p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_IN p = new PortType_IN(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_BookOrders = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_BookOrders",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_IN),
            typeof(__messagetype_BookOrdersSolution_schemas_IncomingBookOrders),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_BookOrders" ] = Operation_BookOrders;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_SendToCRM",
        new System.Type[]{
            typeof(BookOrdersSolution.__messagetype_BookOrdersSolution_schemas_CRMIncomingBookOrders)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_1 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_1(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_1(PortType_1 p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_1 p = new PortType_1(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_SendToCRM = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_SendToCRM",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_1),
            typeof(__messagetype_BookOrdersSolution_schemas_CRMIncomingBookOrders),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_SendToCRM" ] = Operation_SendToCRM;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 301 "C:\APRESS\Chapter5\PerformanceCounters\BookOrdersSolution\BookOrdersSolution\orchestrations\orcProcessBookOrders.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "Port_IN", "Operation_BookOrders", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(BookOrdersSolution.PortType_IN),
            typeof(BookOrdersSolution.PortType_1)
        },
        new System.String[] {
            "Port_IN",
            "Port_OUT"
        },
        new System.Type[] {
            null,
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
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone|Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eLongRunning
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class orcProcessBookOrders : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(orcProcessBookOrders));
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

        static orcProcessBookOrders()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment2), 1, 2, 2),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment3), 1, 3, 3),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment4), 1, 3, 4),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment5), 1, 2, 5)
            };

            _Locks = 0;
            _rootContext = new __orcProcessBookOrders_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[4];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public orcProcessBookOrders(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "orcProcessBookOrders", tracker)
        {
            ConstructorHelper();
        }

        public orcProcessBookOrders(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "orcProcessBookOrders")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>bcf28344-77e5-490a-82ed-a1aa9420bd35</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>e697fc10-04ea-49b1-9407-d505f3da1a41</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_BookOrders</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>77ed0552-8372-4db4-9363-5343b8f4a0ce</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>SetPerfCounters</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>c8c07732-be3e-4549-b861-cb579031b6ce</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>WriteLog</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>05bfab7e-31c8-4759-b343-4d810909bf02</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Scope_Main</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>LongRunningTransactionShape</shapeType>      <ShapeID>78a1202d-2e41-4545-bc01-6b4d5bf8868a</ShapeID>      <ParentLink>Scope_Transaction</ParentLink>                <shapeText>Transaction_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>fd482431-7c2b-4895-ae79-f6bf1e0ac682</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Decide_VIP</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>b83d5572-0940-45a5-ac6e-6338c5885e42</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Rule_VIP</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>4285a4f3-5a51-4aa7-b7a4-50f2b9338df4</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Congratulate</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>1fe667f9-c0e0-4fbd-8c6c-9b97c66ce366</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>8006cad1-5131-46fe-ad4f-92f66182fbdb</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>08e42287-4cbf-437f-b0fe-d7cae9a2c09a</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>01805d11-7f84-4af0-815c-fd415ef569cb</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>66bf66e1-2d1e-405d-a247-fc6bee3e5826</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>e7c52154-8e08-43e8-85ec-d7b391055b63</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>nonVIPCustomer</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>ea0fb64a-8c38-4209-9c37-5fb104468fdb</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>dea125e0-3290-4b68-acb9-29e5d50a3e1e</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>64a59132-3657-4525-b1f0-c062da0575a6</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>5e668e7f-baeb-410f-a512-8e57a8fafc89</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>9e6a21b5-62c4-459e-bdab-cb5afd66bc02</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Scope_Send</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>LongRunningTransactionShape</shapeType>      <ShapeID>4cc3196e-c5cb-47a9-9809-33dfdd2b93bc</ShapeID>      <ParentLink>Scope_Transaction</ParentLink>                <shapeText>Transaction_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>acfbc6d0-cd8e-4941-b5c6-653573086509</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_ToCRM</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>fac1d2ab-1473-4074-86de-33eb1d0157c7</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>SetSentPerfCounter</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>84d6a99c-33f9-439d-bc5d-a1fc0fcfd803</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>CatchException_ExSend</shapeText>                      <ExceptionType>System.Exception</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>TerminateShape</shapeType>      <ShapeID>bbfe96e2-9b0c-4808-8745-fa47356d1116</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Terminate_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>85b35a3c-7928-40e2-ae8e-f59a02a39a0f</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>CatchException_ex</shapeText>                      <ExceptionType>System.Exception</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>TerminateShape</shapeType>      <ShapeID>cebe0135-663b-476e-83b5-7352c39d9704</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Terminate_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'orcProcessBookOrders'</ActionName><IsAtomic>0</IsAtomic><Line>301</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>313</Line><Position>22</Position><ShapeID>'e697fc10-04ea-49b1-9407-d505f3da1a41'</ShapeID>
<Messages>
	<MsgInfo><name>msgOrdersIN</name><part>part</part><schema>BookOrdersSolution.schemas.IncomingBookOrders</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>316</Line><Position>24</Position><ShapeID>'77ed0552-8372-4db4-9363-5343b8f4a0ce'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>320</Line><Position>51</Position><ShapeID>'c8c07732-be3e-4549-b861-cb579031b6ce'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'Transaction_3'</ActionName><IsAtomic>0</IsAtomic><Line>323</Line><Position>13</Position><ShapeID>'05bfab7e-31c8-4759-b343-4d810909bf02'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>328</Line><Position>21</Position><ShapeID>'fd482431-7c2b-4895-ae79-f6bf1e0ac682'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>331</Line><Position>25</Position><ShapeID>'4285a4f3-5a51-4aa7-b7a4-50f2b9338df4'</ShapeID>
<Messages>
	<MsgInfo><name>msgToCRM</name><part>part</part><schema>BookOrdersSolution.schemas.CRMIncomingBookOrders</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>msgOrdersIN</name><part>part</part><schema>BookOrdersSolution.schemas.IncomingBookOrders</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>340</Line><Position>25</Position><ShapeID>'e7c52154-8e08-43e8-85ec-d7b391055b63'</ShapeID>
<Messages>
	<MsgInfo><name>msgToCRM</name><part>part</part><schema>BookOrdersSolution.schemas.CRMIncomingBookOrders</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>msgOrdersIN</name><part>part</part><schema>BookOrdersSolution.schemas.IncomingBookOrders</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'Transaction_2'</ActionName><IsAtomic>0</IsAtomic><Line>347</Line><Position>21</Position><ShapeID>'9e6a21b5-62c4-459e-bdab-cb5afd66bc02'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>352</Line><Position>29</Position><ShapeID>'acfbc6d0-cd8e-4941-b5c6-653573086509'</ShapeID>
<Messages>
	<MsgInfo><name>msgToCRM</name><part>part</part><schema>BookOrdersSolution.schemas.CRMIncomingBookOrders</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>354</Line><Position>58</Position><ShapeID>'fac1d2ab-1473-4074-86de-33eb1d0157c7'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>359</Line><Position>29</Position><ShapeID>'84d6a99c-33f9-439d-bc5d-a1fc0fcfd803'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>362</Line><Position>33</Position><ShapeID>'bbfe96e2-9b0c-4808-8745-fa47356d1116'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>370</Line><Position>21</Position><ShapeID>'85b35a3c-7928-40e2-ae8e-f59a02a39a0f'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>373</Line><Position>25</Position><ShapeID>'cebe0135-663b-476e-83b5-7352c39d9704'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='17a6dd44-8e9a-40a6-bd48-9ae935c9daec' LowerBound='1.1' HigherBound='98.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='BookOrdersSolution' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='83e75b7a-1a6e-4d8e-9385-81e4807251bf' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_IN' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='e4653285-8bab-412a-9f8a-6233b4d314e5' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_BookOrders' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='4541ae45-48e6-41db-89c5-227ff47a9783' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.39'>
                    <om:Property Name='Ref' Value='BookOrdersSolution.schemas.IncomingBookOrders' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='5cd336a3-c134-4b9f-8c66-e8b4bec0fb15' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='39324a90-1b61-4dff-b68e-a51ea62451bf' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_SendToCRM' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='e86cb843-8d62-4f1c-952b-efca61b251dc' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.42'>
                    <om:Property Name='Ref' Value='BookOrdersSolution.schemas.CRMIncomingBookOrders' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='dcefb250-1e07-4d0a-85be-d3342ad8b916' ParentLink='Module_ServiceDeclaration' LowerBound='18.1' HigherBound='97.1'>
            <om:Property Name='InitializedTransactionType' Value='True' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='orcProcessBookOrders' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='c36f791a-24d4-4313-9976-7bef87021df3' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='27.1' HigherBound='28.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='PerformanceCounterHelper.PerformanceCounterHelperClass' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='perfHelper' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='LongRunningTransaction' OID='0126094d-0e78-480a-986c-167b2ee033c3' ParentLink='ServiceDeclaration_Transaction' LowerBound='19.21' HigherBound='19.66'>
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Transaction_1' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='2d51bd57-06fc-4eda-9a39-c34db1066e59' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='BookOrdersSolution.schemas.IncomingBookOrders' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgOrdersIN' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='147ab23b-9632-4136-b164-a3418191b574' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='Type' Value='BookOrdersSolution.schemas.CRMIncomingBookOrders' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgToCRM' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='bcf28344-77e5-490a-82ed-a1aa9420bd35' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='e697fc10-04ea-49b1-9407-d505f3da1a41' ParentLink='ServiceBody_Statement' LowerBound='30.1' HigherBound='32.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='Port_IN' />
                    <om:Property Name='MessageName' Value='msgOrdersIN' />
                    <om:Property Name='OperationName' Value='Operation_BookOrders' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_BookOrders' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='77ed0552-8372-4db4-9363-5343b8f4a0ce' ParentLink='ServiceBody_Statement' LowerBound='32.1' HigherBound='37.1'>
                    <om:Property Name='Expression' Value='//it is a performance counter with versioned orchestration so we add the version&#xD;&#xA;perfHelper = new PerformanceCounterHelper.PerformanceCounterHelperClass(&quot;ProcessBookOrders&quot;,&quot;2.0&quot;,false);&#xD;&#xA;perfHelper.addValueToACounter(&quot;ProcessBookOrders&quot;,&quot;# Received Messages&quot;,&quot;orcProcessBookOrders&quot;);&#xD;&#xA;&#xD;&#xA;' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='SetPerfCounters' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='c8c07732-be3e-4549-b861-cb579031b6ce' ParentLink='ServiceBody_Statement' LowerBound='37.1' HigherBound='40.1'>
                    <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;Orchestration Version 2&quot;, &quot;new Message Received in orchestration verssion 2&quot;);  &#xD;&#xA;&#xD;&#xA;' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='WriteLog' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Scope' OID='05bfab7e-31c8-4759-b343-4d810909bf02' ParentLink='ServiceBody_Statement' LowerBound='40.1' HigherBound='95.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Scope_Main' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='LongRunningTransaction' OID='78a1202d-2e41-4545-bc01-6b4d5bf8868a' ParentLink='Scope_Transaction' LowerBound='41.18' HigherBound='41.56'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transaction_3' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Decision' OID='fd482431-7c2b-4895-ae79-f6bf1e0ac682' ParentLink='ComplexStatement_Statement' LowerBound='45.1' HigherBound='64.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Decide_VIP' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='DecisionBranch' OID='b83d5572-0940-45a5-ac6e-6338c5885e42' ParentLink='ReallyComplexStatement_Branch' LowerBound='46.21' HigherBound='55.1'>
                            <om:Property Name='Expression' Value='msgOrdersIN(BookOrdersSolution.PropertySchema.isVIPCustomer)==&quot;1&quot;' />
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Rule_VIP' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Construct' OID='4285a4f3-5a51-4aa7-b7a4-50f2b9338df4' ParentLink='ComplexStatement_Statement' LowerBound='48.1' HigherBound='54.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Congratulate' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='Transform' OID='1fe667f9-c0e0-4fbd-8c6c-9b97c66ce366' ParentLink='ComplexStatement_Statement' LowerBound='51.1' HigherBound='53.1'>
                                    <om:Property Name='ClassName' Value='BookOrdersSolution.maps.Map_IncomingMessage_To_CRM_CongratuleMessage' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Transform_1' />
                                    <om:Property Name='Signal' Value='False' />
                                    <om:Element Type='MessagePartRef' OID='8006cad1-5131-46fe-ad4f-92f66182fbdb' ParentLink='Transform_InputMessagePartRef' LowerBound='52.122' HigherBound='52.133'>
                                        <om:Property Name='MessageRef' Value='msgOrdersIN' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_1' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessagePartRef' OID='08e42287-4cbf-437f-b0fe-d7cae9a2c09a' ParentLink='Transform_OutputMessagePartRef' LowerBound='52.40' HigherBound='52.48'>
                                        <om:Property Name='MessageRef' Value='msgToCRM' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_2' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='MessageRef' OID='01805d11-7f84-4af0-815c-fd415ef569cb' ParentLink='Construct_MessageRef' LowerBound='49.35' HigherBound='49.43'>
                                    <om:Property Name='Ref' Value='msgToCRM' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                        </om:Element>
                        <om:Element Type='DecisionBranch' OID='66bf66e1-2d1e-405d-a247-fc6bee3e5826' ParentLink='ReallyComplexStatement_Branch'>
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Else' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Construct' OID='e7c52154-8e08-43e8-85ec-d7b391055b63' ParentLink='ComplexStatement_Statement' LowerBound='57.1' HigherBound='63.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='nonVIPCustomer' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='Transform' OID='ea0fb64a-8c38-4209-9c37-5fb104468fdb' ParentLink='ComplexStatement_Statement' LowerBound='60.1' HigherBound='62.1'>
                                    <om:Property Name='ClassName' Value='BookOrdersSolution.maps.Map_IncomingBookOrders_To_CRMFormat' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Transform_2' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='MessagePartRef' OID='dea125e0-3290-4b68-acb9-29e5d50a3e1e' ParentLink='Transform_InputMessagePartRef' LowerBound='61.113' HigherBound='61.124'>
                                        <om:Property Name='MessageRef' Value='msgOrdersIN' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_3' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessagePartRef' OID='64a59132-3657-4525-b1f0-c062da0575a6' ParentLink='Transform_OutputMessagePartRef' LowerBound='61.40' HigherBound='61.48'>
                                        <om:Property Name='MessageRef' Value='msgToCRM' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_4' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='MessageRef' OID='5e668e7f-baeb-410f-a512-8e57a8fafc89' ParentLink='Construct_MessageRef' LowerBound='58.35' HigherBound='58.43'>
                                    <om:Property Name='Ref' Value='msgToCRM' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Scope' OID='9e6a21b5-62c4-459e-bdab-cb5afd66bc02' ParentLink='ComplexStatement_Statement' LowerBound='64.1' HigherBound='84.1'>
                        <om:Property Name='InitializedTransactionType' Value='True' />
                        <om:Property Name='IsSynchronized' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Scope_Send' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='LongRunningTransaction' OID='4cc3196e-c5cb-47a9-9809-33dfdd2b93bc' ParentLink='Scope_Transaction' LowerBound='65.26' HigherBound='65.64'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Transaction_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='Send' OID='acfbc6d0-cd8e-4941-b5c6-653573086509' ParentLink='ComplexStatement_Statement' LowerBound='69.1' HigherBound='71.1'>
                            <om:Property Name='PortName' Value='Port_OUT' />
                            <om:Property Name='MessageName' Value='msgToCRM' />
                            <om:Property Name='OperationName' Value='Operation_SendToCRM' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send_ToCRM' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='VariableAssignment' OID='fac1d2ab-1473-4074-86de-33eb1d0157c7' ParentLink='ComplexStatement_Statement' LowerBound='71.1' HigherBound='73.1'>
                            <om:Property Name='Expression' Value='perfHelper.addValueToACounter(&quot;ProcessBookOrders&quot;,&quot;# Sent Messages&quot;,&quot;orcProcessBookOrders&quot;);' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='SetSentPerfCounter' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Catch' OID='84d6a99c-33f9-439d-bc5d-a1fc0fcfd803' ParentLink='Scope_Catch' LowerBound='76.1' HigherBound='82.1'>
                            <om:Property Name='ExceptionName' Value='ExSend' />
                            <om:Property Name='ExceptionType' Value='System.Exception' />
                            <om:Property Name='IsFaultMessage' Value='False' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='CatchException_ExSend' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Terminate' OID='bbfe96e2-9b0c-4808-8745-fa47356d1116' ParentLink='Catch_Statement' LowerBound='79.1' HigherBound='81.1'>
                                <om:Property Name='ErrorMessage' Value='ExSend.Message;' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Terminate_2' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Catch' OID='85b35a3c-7928-40e2-ae8e-f59a02a39a0f' ParentLink='Scope_Catch' LowerBound='87.1' HigherBound='93.1'>
                        <om:Property Name='ExceptionName' Value='exMain' />
                        <om:Property Name='ExceptionType' Value='System.Exception' />
                        <om:Property Name='IsFaultMessage' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='CatchException_ex' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Terminate' OID='cebe0135-663b-476e-83b5-7352c39d9704' ParentLink='Catch_Statement' LowerBound='90.1' HigherBound='92.1'>
                            <om:Property Name='ErrorMessage' Value='exMain.Message;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Terminate_1' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='b1c8c73c-6a95-4f6d-9be1-fb8fa14c645f' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='21.1' HigherBound='23.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='BookOrdersSolution.PortType_IN' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_IN' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='5c2a0165-af29-4e21-8006-53e88695fd86' ParentLink='PortDeclaration_CLRAttribute' LowerBound='21.1' HigherBound='22.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='9cfa4f24-c5d9-43ee-afdf-73338187dfb5' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='23.1' HigherBound='25.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='BookOrdersSolution.PortType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_OUT' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='bc3287b2-3c69-424f-8405-8dc29daceb85' ParentLink='PortDeclaration_CLRAttribute' LowerBound='23.1' HigherBound='24.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __orcProcessBookOrders_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __orcProcessBookOrders_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "orcProcessBookOrders")
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
                orcProcessBookOrders __svc__ = (orcProcessBookOrders)_service;
                __orcProcessBookOrders_root_0 __ctx0__ = (__orcProcessBookOrders_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.Port_IN != null)
                {
                    __svc__.Port_IN.Close(this, null);
                    __svc__.Port_IN = null;
                }
                if (__svc__.Port_OUT != null)
                {
                    __svc__.Port_OUT.Close(this, null);
                    __svc__.Port_OUT = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __orcProcessBookOrders_1 : Microsoft.XLANGs.Core.LongRunningTransaction
        {
            public __orcProcessBookOrders_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "orcProcessBookOrders")
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
                orcProcessBookOrders __svc__ = (orcProcessBookOrders)_service;
                __orcProcessBookOrders_1 __ctx1__ = (__orcProcessBookOrders_1)(__svc__._stateMgrs[1]);
                __Transaction_3_2 __ctx2__ = (__Transaction_3_2)(__svc__._stateMgrs[2]);

                if (__ctx1__ != null)
                    __ctx1__.__perfHelper = null;
                if (__ctx1__ != null && __ctx1__.__msgToCRM != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgToCRM);
                    __ctx1__.__msgToCRM = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgOrdersIN != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgOrdersIN);
                    __ctx1__.__msgOrdersIN = null;
                }
                if (__ctx2__ != null && __ctx2__.__msgToCRM != null)
                {
                    __ctx2__.UnrefMessage(__ctx2__.__msgToCRM);
                    __ctx2__.__msgToCRM = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgOrdersIN")]
            public __messagetype_BookOrdersSolution_schemas_IncomingBookOrders __msgOrdersIN;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgToCRM")]
            public __messagetype_BookOrdersSolution_schemas_CRMIncomingBookOrders __msgToCRM;
            [Microsoft.XLANGs.Core.UserVariableAttribute("perfHelper")]
            internal PerformanceCounterHelper.PerformanceCounterHelperClass __perfHelper;
        }


        [System.SerializableAttribute]
        public class __Transaction_3_2 : Microsoft.XLANGs.Core.LongRunningTransaction
        {
            public __Transaction_3_2(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Transaction_3")
            {
            }

            public override int Index { get { return 2; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[2]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[2]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Microsoft.XLANGs.Core.Segment __seg__;
                Microsoft.XLANGs.Core.FaultReceiveException __fault__;

                __exv__ = _exception;
                if (!(__exv__ is Microsoft.XLANGs.Core.UnknownException))
                {
                    __fault__ = __exv__ as Microsoft.XLANGs.Core.FaultReceiveException;
                    if ((__fault__ == null) && (__exv__ is System.Exception))
                    {
                        __seg__ = _service._segments[5];
                        __seg__.Reset(1);
                        __seg__.PredecessorDone(_service);
                        return true;
                    }
                }

                Finally();
                return false;
            }

            public override void Finally()
            {
                orcProcessBookOrders __svc__ = (orcProcessBookOrders)_service;
                __orcProcessBookOrders_1 __ctx1__ = (__orcProcessBookOrders_1)(__svc__._stateMgrs[1]);
                __Transaction_3_2 __ctx2__ = (__Transaction_3_2)(__svc__._stateMgrs[2]);
                __Transaction_2_3 __ctx3__ = (__Transaction_2_3)(__svc__._stateMgrs[3]);

                if (__ctx1__.__msgToCRM != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgToCRM);
                __ctx1__.__msgToCRM = __ctx2__.__msgToCRM;
                if (__ctx2__.__msgToCRM != null)
                    __ctx1__.RefMessage(__ctx1__.__msgToCRM);
                if (__ctx2__ != null)
                    __ctx2__.__exMain_0 = null;
                if (__ctx3__ != null)
                    __ctx3__.__perfHelper = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgToCRM")]
            public __messagetype_BookOrdersSolution_schemas_CRMIncomingBookOrders __msgToCRM;
            internal object __exv__;
            internal System.Exception __exMain_0
            {
                get { return (System.Exception)__exv__; }
                set { __exv__ = value; }
            }
        }


        [System.SerializableAttribute]
        public class __Transaction_2_3 : Microsoft.XLANGs.Core.LongRunningTransaction
        {
            public __Transaction_2_3(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Transaction_2")
            {
            }

            public override int Index { get { return 3; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[3]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[3]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Microsoft.XLANGs.Core.Segment __seg__;
                Microsoft.XLANGs.Core.FaultReceiveException __fault__;

                __exv__ = _exception;
                if (!(__exv__ is Microsoft.XLANGs.Core.UnknownException))
                {
                    __fault__ = __exv__ as Microsoft.XLANGs.Core.FaultReceiveException;
                    if ((__fault__ == null) && (__exv__ is System.Exception))
                    {
                        __seg__ = _service._segments[4];
                        __seg__.Reset(1);
                        __seg__.PredecessorDone(_service);
                        return true;
                    }
                }

                Finally();
                return false;
            }

            public override void Finally()
            {
                orcProcessBookOrders __svc__ = (orcProcessBookOrders)_service;
                __orcProcessBookOrders_1 __ctx1__ = (__orcProcessBookOrders_1)(__svc__._stateMgrs[1]);
                __Transaction_2_3 __ctx3__ = (__Transaction_2_3)(__svc__._stateMgrs[3]);

                __ctx1__.__perfHelper = __ctx3__.__perfHelper;
                if (__ctx3__ != null)
                    __ctx3__.__ExSend_0 = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("perfHelper")]
            internal PerformanceCounterHelper.PerformanceCounterHelperClass __perfHelper;
            internal object __exv__;
            internal System.Exception __ExSend_0
            {
                get { return (System.Exception)__exv__; }
                set { __exv__ = value; }
            }
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_IN")]
        internal PortType_IN Port_IN;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_OUT")]
        internal PortType_1 Port_OUT;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_IN.Operation_BookOrders},
                                               typeof(orcProcessBookOrders).GetField("Port_IN", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(orcProcessBookOrders), "Port_IN"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_1.Operation_SendToCRM},
                                               typeof(orcProcessBookOrders).GetField("Port_OUT", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(orcProcessBookOrders), "Port_OUT"),
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
                h[_portInfo[1].Name] = _portInfo[1];
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "e697fc10-04ea-49b1-9407-d505f3da1a41", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "e697fc10-04ea-49b1-9407-d505f3da1a41", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "77ed0552-8372-4db4-9363-5343b8f4a0ce", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "77ed0552-8372-4db4-9363-5343b8f4a0ce", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "c8c07732-be3e-4549-b861-cb579031b6ce", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "c8c07732-be3e-4549-b861-cb579031b6ce", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "05bfab7e-31c8-4759-b343-4d810909bf02", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "fd482431-7c2b-4895-ae79-f6bf1e0ac682", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "4285a4f3-5a51-4aa7-b7a4-50f2b9338df4", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "4285a4f3-5a51-4aa7-b7a4-50f2b9338df4", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "e7c52154-8e08-43e8-85ec-d7b391055b63", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "e7c52154-8e08-43e8-85ec-d7b391055b63", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "fd482431-7c2b-4895-ae79-f6bf1e0ac682", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "9e6a21b5-62c4-459e-bdab-cb5afd66bc02", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "00000000-0000-0000-0000-000000000000", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "acfbc6d0-cd8e-4941-b5c6-653573086509", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "acfbc6d0-cd8e-4941-b5c6-653573086509", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "fac1d2ab-1473-4074-86de-33eb1d0157c7", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "fac1d2ab-1473-4074-86de-33eb1d0157c7", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "84d6a99c-33f9-439d-bc5d-a1fc0fcfd803", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "bbfe96e2-9b0c-4808-8745-fa47356d1116", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "84d6a99c-33f9-439d-bc5d-a1fc0fcfd803", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(25, "9e6a21b5-62c4-459e-bdab-cb5afd66bc02", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(26, "85b35a3c-7928-40e2-ae8e-f59a02a39a0f", 5, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(27, "cebe0135-663b-476e-83b5-7352c39d9704", 5, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(28, "85b35a3c-7928-40e2-ae8e-f59a02a39a0f", 5, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(29, "05bfab7e-31c8-4759-b343-4d810909bf02", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Terminate),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,5,5,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,3,3,4,4,6,6,7,8,8,8,29,5,5,5,5,};
        public static int[] __progressLocation2 = new int[] { 10,10,10,11,11,12,10,13,13,14,15,16,16,16,25,25,25,25,};
        public static int[] __progressLocation3 = new int[] { 18,18,18,18,19,20,20,21,21,21,21,};
        public static int[] __progressLocation4 = new int[] { 22,22,23,23,24,24,};
        public static int[] __progressLocation5 = new int[] { 26,26,27,27,28,28,};

        public static int[][] __progressLocations = new int[6] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3,__progressLocation4,__progressLocation5};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __orcProcessBookOrders_root_0 __ctx0__ = (__orcProcessBookOrders_root_0)_stateMgrs[0];
            __orcProcessBookOrders_1 __ctx1__ = (__orcProcessBookOrders_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                Port_IN = new PortType_IN(0, this);
                Port_OUT = new PortType_1(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], Port_IN, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __orcProcessBookOrders_1(this);
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
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __orcProcessBookOrders_root_0 __ctx0__ = (__orcProcessBookOrders_root_0)_stateMgrs[0];
            __orcProcessBookOrders_1 __ctx1__ = (__orcProcessBookOrders_1)_stateMgrs[1];
            __Transaction_3_2 __ctx2__ = (__Transaction_3_2)_stateMgrs[2];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__perfHelper = default(PerformanceCounterHelper.PerformanceCounterHelperClass);
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
                if (!Port_IN.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msgOrdersIN != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgOrdersIN);
                __ctx1__.__msgOrdersIN = new __messagetype_BookOrdersSolution_schemas_IncomingBookOrders("msgOrdersIN", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgOrdersIN);
                Port_IN.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgOrdersIN, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (Port_IN != null)
                {
                    Port_IN.Close(__ctx1__, __seg__);
                    Port_IN = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgOrdersIN);
                    __edata.PortName = @"Port_IN";
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
                __ctx1__.__perfHelper = new PerformanceCounterHelper.PerformanceCounterHelperClass("ProcessBookOrders", "2.0", false);
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
                __ctx1__.__perfHelper.addValueToACounter("ProcessBookOrders", "# Received Messages", "orcProcessBookOrders");
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                System.Diagnostics.EventLog.WriteEntry("Orchestration Version 2", "new Message Received in orchestration verssion 2");
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                __ctx2__ = new __Transaction_3_2(this);
                _stateMgrs[2] = __ctx2__;
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                __ctx1__.StartContext(__seg__, __ctx2__);
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__perfHelper = null;
                if (__ctx1__ != null && __ctx1__.__msgOrdersIN != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgOrdersIN);
                    __ctx1__.__msgOrdersIN = null;
                }
                if (Port_OUT != null)
                {
                    Port_OUT.Close(__ctx1__, __seg__);
                    Port_OUT = null;
                }
                Tracker.FireEvent(__eventLocations[29],__eventData[12],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (__ctx2__ != null && __ctx2__.__msgToCRM != null)
                {
                    __ctx2__.UnrefMessage(__ctx2__.__msgToCRM);
                    __ctx2__.__msgToCRM = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgToCRM != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgToCRM);
                    __ctx1__.__msgToCRM = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[13],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 19;
            case 19:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment2(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[2];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            __orcProcessBookOrders_1 __ctx1__ = (__orcProcessBookOrders_1)_stateMgrs[1];
            __Transaction_3_2 __ctx2__ = (__Transaction_3_2)_stateMgrs[2];
            __Transaction_2_3 __ctx3__ = (__Transaction_2_3)_stateMgrs[3];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx2__.__msgToCRM = __ctx1__.__msgToCRM;
                if (__ctx2__.__msgToCRM != null)
                    __ctx2__.RefMessage(__ctx2__.__msgToCRM);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                __condition__ = (System.String)__ctx1__.__msgOrdersIN.GetPropertyValueThrows(typeof(BookOrdersSolution.PropertySchema.isVIPCustomer)) == "1";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 7;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                {
                    __messagetype_BookOrdersSolution_schemas_CRMIncomingBookOrders __msgToCRM = new __messagetype_BookOrdersSolution_schemas_CRMIncomingBookOrders("msgToCRM", __ctx2__);

                    ApplyTransform(typeof(BookOrdersSolution.maps.Map_IncomingMessage_To_CRM_CongratuleMessage), new object[] {__msgToCRM.part}, new object[] {__ctx1__.__msgOrdersIN.part});

                    if (__ctx2__.__msgToCRM != null)
                        __ctx2__.UnrefMessage(__ctx2__.__msgToCRM);
                    __ctx2__.__msgToCRM = __msgToCRM;
                    __ctx2__.RefMessage(__ctx2__.__msgToCRM);
                }
                __ctx2__.__msgToCRM.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx2__.__msgToCRM);
                    __edata.Messages.Add(__ctx1__.__msgOrdersIN);
                    Tracker.FireEvent(__eventLocations[12],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                {
                    __messagetype_BookOrdersSolution_schemas_CRMIncomingBookOrders __msgToCRM = new __messagetype_BookOrdersSolution_schemas_CRMIncomingBookOrders("msgToCRM", __ctx2__);

                    ApplyTransform(typeof(BookOrdersSolution.maps.Map_IncomingBookOrders_To_CRMFormat), new object[] {__msgToCRM.part}, new object[] {__ctx1__.__msgOrdersIN.part});

                    if (__ctx2__.__msgToCRM != null)
                        __ctx2__.UnrefMessage(__ctx2__.__msgToCRM);
                    __ctx2__.__msgToCRM = __msgToCRM;
                    __ctx2__.RefMessage(__ctx2__.__msgToCRM);
                }
                __ctx2__.__msgToCRM.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx2__.__msgToCRM);
                    __edata.Messages.Add(__ctx1__.__msgOrdersIN);
                    Tracker.FireEvent(__eventLocations[14],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[15],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                __ctx3__ = new __Transaction_2_3(this);
                _stateMgrs[3] = __ctx3__;
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                __ctx2__.StartContext(__seg__, __ctx3__);
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[25],__eventData[12],_stateMgrs[2].TrackDataStream );
                __ctx3__.Finally();
                if (__ctx3__ != null)
                    __ctx3__.__perfHelper = null;
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 17;
            case 17:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment3(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[3];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[3];
            __orcProcessBookOrders_root_0 __ctx0__ = (__orcProcessBookOrders_root_0)_stateMgrs[0];
            __orcProcessBookOrders_1 __ctx1__ = (__orcProcessBookOrders_1)_stateMgrs[1];
            __Transaction_3_2 __ctx2__ = (__Transaction_3_2)_stateMgrs[2];
            __Transaction_2_3 __ctx3__ = (__Transaction_2_3)_stateMgrs[3];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx3__.__perfHelper = __ctx1__.__perfHelper;
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[8],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if (!__ctx3__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_OUT.SendMessage(0, __ctx2__.__msgToCRM, null, null, __ctx3__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx2__.__msgToCRM);
                    __edata.PortName = @"Port_OUT";
                    Tracker.FireEvent(__eventLocations[19],__edata,_stateMgrs[3].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[20],__eventData[2],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                __ctx3__.__perfHelper.addValueToACounter("ProcessBookOrders", "# Sent Messages", "orcProcessBookOrders");
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[21],__eventData[3],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if (!__ctx3__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx3__.OnCommit();
                goto case 10;
            case 10:
                __seg__.SegmentDone();
                _segments[2].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment4(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[4];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[3];
            __Transaction_2_3 __ctx3__ = (__Transaction_2_3)_stateMgrs[3];

            switch (__seg__.Progress)
            {
            case 0:
                OnBeginCatchHandler(3);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[22],__eventData[9],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[23],__eventData[10],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                RequestTerminate(__ctx3__,__ctx3__.__ExSend_0.Message);
                __seg__.SegmentDone();
                if (__ctx3__ != null)
                    __ctx3__.__ExSend_0 = null;
                break;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[24],__eventData[11],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx3__.__exv__ = null;
                OnEndCatchHandler(3, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment5(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[5];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            __Transaction_3_2 __ctx2__ = (__Transaction_3_2)_stateMgrs[2];

            switch (__seg__.Progress)
            {
            case 0:
                OnBeginCatchHandler(2);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[26],__eventData[9],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[27],__eventData[10],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                RequestTerminate(__ctx2__,__ctx2__.__exMain_0.Message);
                __seg__.SegmentDone();
                if (__ctx2__ != null)
                    __ctx2__.__exMain_0 = null;
                break;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[28],__eventData[11],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx2__.__exv__ = null;
                OnEndCatchHandler(2, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __BookOrdersSolution_schemas_IncomingBookOrders__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static BookOrdersSolution.schemas.IncomingBookOrders _schema = new BookOrdersSolution.schemas.IncomingBookOrders();

        public __BookOrdersSolution_schemas_IncomingBookOrders__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "BookOrdersSolution.schemas.IncomingBookOrders",
        new System.Type[]{
            typeof(BookOrdersSolution.schemas.IncomingBookOrders)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__BookOrdersSolution_schemas_IncomingBookOrders__)
        },
        0,
        @"http://BookOrdersSolution.IncomingBookOrders#IncomingBookOrders"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_BookOrdersSolution_schemas_IncomingBookOrders : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __BookOrdersSolution_schemas_IncomingBookOrders__ part;

        private void __CreatePartWrappers()
        {
            part = new __BookOrdersSolution_schemas_IncomingBookOrders__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_BookOrdersSolution_schemas_IncomingBookOrders(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __BookOrdersSolution_schemas_CRMIncomingBookOrders__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static BookOrdersSolution.schemas.CRMIncomingBookOrders _schema = new BookOrdersSolution.schemas.CRMIncomingBookOrders();

        public __BookOrdersSolution_schemas_CRMIncomingBookOrders__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "BookOrdersSolution.schemas.CRMIncomingBookOrders",
        new System.Type[]{
            typeof(BookOrdersSolution.schemas.CRMIncomingBookOrders)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__BookOrdersSolution_schemas_CRMIncomingBookOrders__)
        },
        0,
        @"http://BookOrdersSolution.CRMIncomingBookOrders#CRMData"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_BookOrdersSolution_schemas_CRMIncomingBookOrders : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __BookOrdersSolution_schemas_CRMIncomingBookOrders__ part;

        private void __CreatePartWrappers()
        {
            part = new __BookOrdersSolution_schemas_CRMIncomingBookOrders__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_BookOrdersSolution_schemas_CRMIncomingBookOrders(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
