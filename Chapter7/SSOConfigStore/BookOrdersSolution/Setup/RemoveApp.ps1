."C:\APRESS\Chapter7\UtilityScripts\psFunctions.ps1"

echo off
powershell Set-ExecutionPolicy unrestricted

$appName = "BookOrdersApplication"

StopBTSApplication $appName 

RemoveBTSApplication $appName