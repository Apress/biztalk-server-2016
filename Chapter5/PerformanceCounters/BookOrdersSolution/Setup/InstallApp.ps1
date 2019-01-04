#including the custom functions
."C:\APRESS\UtilityScripts\psFunctions.ps1"

echo off
powershell Set-ExecutionPolicy unrestricted

$appName = "BookOrdersApplication"
$appBindingFile = "C:\APRESS\Chapter5\PerformanceCounters\BookOrdersSolution\BookOrdersSolution\Bindings\Bindings.xml"
$VisualStudioSolutionPath = "C:\APRESS\Chapter5\PerformanceCounters\BookOrdersSolution\BookOrdersSolution.sln"
$PerformaceCounterHelperPath = "C:\APRESS\Chapter5\PerformanceCounters\BookOrdersSolution\PerformanceCounterHelper\bin\Debug\PerformanceCounterHelper.dll"
$BooksOrderHelperPath = "C:\APRESS\Chapter5\PerformanceCounters\BookOrdersSolution\BooksOrderHelper\bin\Debug\BooksOrderHelper.dll"
#BTSTask.exe AddApp -ApplicationName:$appName #we create the application


#Cleaning the MessageBOxDb
#Clean-MessageBoxDb

#Deploy the app from VisualStudio
DeployVSSolution $VisualStudioSolutionPath
#improt bidings
ImportBTSBindingFile  $appBindingFile  $appName
#install assemblies in gac

InstallAssemblyToGAC $PerformaceCounterHelperPath
InstallAssemblyToGAC $BooksOrderHelperPath

#add the helpers as resources to the application
BTSTask AddResource /ApplicationName:$appName  /Type:System.BizTalk:Assembly  /Source:$PerformaceCounterHelperPath #/Server:MyDatabaseServer /Database:BizTalkMgmtDb
BTSTask AddResource /ApplicationName:$appName  /Type:System.BizTalk:Assembly /Source:$BooksOrderHelperPath #/Server:MyDatabaseServer /Database:BizTalkMgmtDb


#start the applicationd and restart the hostinstances
StartBTSApplication $appName
net stop 'BTSSvc$BizTalkServerApplication'
net start 'BTSSvc$BizTalkServerApplication'


