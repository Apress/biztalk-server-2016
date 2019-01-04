REM == startBtServices.cmd =======================================
REM =  Some Windows services may have failed to start during 
REM =  system boot-up, particularly if the boot sequence took
REM =  longer than average.
REM =  This script ensures that the required services are started
REM ==============================================================

net start MSDTC
net start MSSQLSERVER
net start SQLSERVERAGENT
net start W3SVC
net start SMTPSVC
net start ENTSSO
net start RuleEngineUpdateService
net stop BTSSvc$BizTalkServerApplication
net start BTSSvc$BizTalkServerApplication

REM == Service start-up is complete. ============================
