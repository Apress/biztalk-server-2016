

USE BizTalkMsgBoxDb


SELECT count(*)  as [Number of active subscriptions]
FROM Services s WITH(NOLOCK)
LEFT OUTER JOIN Modules m WITH(NOLOCK) ON s.nModuleID = m.nModuleID 
LEFT OUTER JOIN Subscription sub WITH(NOLOCK) ON s.uidServiceID = sub.uidServiceID
LEFT OUTER JOIN PredicateGroup pg WITH(NOLOCK) ON sub.uidPredicateGroupID = pg.uidPredicateORGroupID 
LEFT OUTER JOIN FirstPassPredicates fp WITH(NOLOCK) ON pg.uidPredicateANDGroupID = fp.uidPredicateGroupID 
LEFT OUTER JOIN EqualsPredicates eq WITH(NOLOCK) ON pg.uidPredicateANDGroupID = eq.uidPredicateGroupID 
LEFT OUTER JOIN EqualsPredicates2ndPass eq2 WITH(NOLOCK) ON pg.uidPredicateANDGroupID = eq2.uidPredicateGroupID 
LEFT OUTER JOIN BizTalkMgmtDb.dbo.bt_DocumentSpec ds WITH(NOLOCK) ON eq.uidPropID = ds.id
LEFT OUTER JOIN BizTalkMgmtDb.dbo.bts_Orchestration o WITH(NOLOCK) ON s.uidServiceId = o.uidGUID
where m.nvcName =  'OrderMgmt'
