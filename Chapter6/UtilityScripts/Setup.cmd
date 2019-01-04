@ECHO off
ECHO Attaching AdvWorks database....

SqlCmd -d master -E -Q "sp_attach_db 'AdvWorks','C:\AllFiles\LabFiles\Lab1\Setup\AdvWorks.MDF'"

sqlcmd -i .\SetDbPermissions.sql -o Lab1sql.log

ECHO Deploying BizTalk Application

powershell Set-ExecutionPolicy unrestricted

powershell ./Setup.ps1

BTSTask.exe ImportApp -Package:Lab1Start.msi -ApplicationName:"Adventure Works"

Lab1Start.msi /q

REM *** Delete all loans from the [AdvWorks].[dbo].[LOANS] table ***

osql -E -Q "DELETE FROM [AdvWorks].[dbo].[LOANS]" -o lab1sql.log

pause
