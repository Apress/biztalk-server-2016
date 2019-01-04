#including the custom functions
."C:\APRESS\Chapter7\UtilityScripts\psFunctions.ps1"

echo off
powershell Set-ExecutionPolicy unrestricted


$appName = "BookOrdersApplication"
$appBindingFile = "C:\APRESS\Chapter7\SSOConfigStore\BookOrdersSolution\BookOrdersSolution\Bindings\Bindings.xml"
$VisualStudioSolutionPath = "C:\APRESS\Chapter7\SSOConfigStore\BookOrdersSolution\BookOrdersSolution.sln"
$PerformaceCounterHelperPath = "C:\APRESS\Chapter7\SSOConfigStore\BookOrdersSolution\PerformanceCounterHelper\bin\Debug\PerformanceCounterHelper.dll"
$BooksOrderHelperPath = "C:\APRESS\Chapter7\SSOConfigStore\BookOrdersSolution\BooksOrderHelper\bin\Debug\BooksOrderHelper.dll"
$SSOCLientHelperPath = "C:\APRESS\Chapter7\SSOConfigStore\BookOrdersSolution\SSOClientHelper\bin\Debug\SSOClientHelper.dll"
#BTSTask.exe AddApp -ApplicationName:$appName #we create the application


#Deploy the app from VisualStudio
DeployVSSolution $VisualStudioSolutionPath
#improt bidings
ImportBTSBindingFile  $appBindingFile  $appName
#install assemblies in gac
InstallAssemblyToGAC $PerformaceCounterHelperPath
InstallAssemblyToGAC $BooksOrderHelperPath
InstallAssemblyToGAC $SSOCLientHelperPath 


#add the helpers as resources to the application
BTSTask AddResource /ApplicationName:$appName  /Type:System.BizTalk:Assembly  /Source:$PerformaceCounterHelperPath #/Server:MyDatabaseServer /Database:BizTalkMgmtDb
BTSTask AddResource /ApplicationName:$appName  /Type:System.BizTalk:Assembly /Source:$BooksOrderHelperPath #/Server:MyDatabaseServer /Database:BizTalkMgmtDb
BTSTask AddResource /ApplicationName:$appName  /Type:System.BizTalk:Assembly /Source:$SSOCLientHelperPath #/Server:MyDatabaseServer /Database:BizTalkMgmtDb


#start the applicationd and restart the hostinstances
StartBTSApplication $appName
net stop 'BTSSvc$BizTalkServerApplication'
net start 'BTSSvc$BizTalkServerApplication'





#start the applicationd and restart the hostinstances
StartBTSApplication $appName
net stop 'BTSSvc$BizTalkServerApplication'
net start 'BTSSvc$BizTalkServerApplication'


