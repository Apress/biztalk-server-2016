#Variables
echo off

#Used BTSExplorer Tool to access some BizTall API. This is needed for the remove application action as it is removing also all components from GAC
$btsExplorer = "Microsoft.BizTalk.ExplorerOM,culture=neutral,version=3.0.1.0,PublicKeyToken=31bf3856ad364e35"
#BizTalk Server Key
$bizTalkRegRoot = "HKLM:\SOFTWARE\Microsoft\BizTalk Server\3.0\"
#registration root for 32 bits
$vsRegRoot = "HKLM:\SOFTWARE\Microsoft\VisualStudio\14.0\"
#registration root for 64bits
$vsRegRoot64 = "HKLM:\SOFTWARE\Wow6432Node\Microsoft\VisualStudio\14.0\"
#path to the Gac Tool.
$gacExePath =  "C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\Tools\gacutil.exe"



# Load required assemblies
[System.Reflection.Assembly]::Load($btsExplorer) #used only in the remove application command.

#import web admin module for IIS functions



#Functions


#implementedfunctions 

function Clean-MessageBoxDb

{

Write-host "Cleaning the MessageBox" 

SqlCmd -d BizTalkMsgBoxDb -E -Q "bts_CleanupMsgbox"

}
function Get-FunctionsDirectory
{
	$Invocation = (Get-Variable MyInvocation -Scope 0).Value
	# $Invocation = (Get-Variable MyInvocation -Scope Global).Value
	Split-Path $Invocation.ScriptName	
}

function Get-BTSInstallPath
{
    $regRoot = Get-Item $bizTalkRegRoot
    $regValues = Get-ItemProperty $regRoot.PSPath
    $regValues.InstallPath
}


function Get-BTSConnectionString
{
	$group = Get-WmiObject MSBTS_GroupSetting -n root\MicrosoftBizTalkServer
	$dbName = $group.MgmtDBName
	$server = $group.MgmtDBServerName
	
	[System.String]::Concat("server=", $server, ";database=", $dbName, ";Integrated Security=SSPI")
	
}

function Get-BTSApplicationUsersGroup
{
    $hostSettings = get-wmiobject MSBTS_Host -n root\MicrosoftBizTalkServer -filter "IsDefault=True"
    if($hostSettings.NTGroupName -notmatch "\\" -eq $true)
    {
      $computer = Get-WmiObject -Class Win32_ComputerSystem  
      [System.String]::Concat($computer.Name, "\", $hostSettings.NTGroupName)
    }
    else
    {$hostSettings.NTGroupName}
}

function Get-BTSIsoHostUser
{
    $hostSettings = get-wmiobject MSBTS_Host -n root\MicrosoftBizTalkServer -filter "HostType='2'"
    if($hostSettings.LastUsedLogon -notmatch "\\" -eq $true)
    {
      $computer = Get-WmiObject -Class Win32_ComputerSystem  
      [System.String]::Concat($computer.Name, "\", $hostSettings.LastUsedLogon)
    }
    else
    {$hostSettings.LastUsedLogon}
}

function GetProcessorArchitecture
{
    (Get-Item ENV:PROCESSOR_ARCHITECTURE).Value
}

function Get-VisualStudioInstallPath
{
    if((GetProcessorArchitecture) -eq "AMD64")
    {
        $regRoot = Get-Item $vsRegRoot64
    }
    else
    {
        $regRoot = Get-Item $vsRegRoot
    }
    $regValues = Get-ItemProperty $regRoot.PSPath
    $regValues.InstallDir
}






#end utility functions

#GAC Functions

function InstallAssemblyToGAC
{
    param([string]$assemblyPath)
    
write-host "Installing assemly $assemblyPath into GAC"
           
[System.Reflection.Assembly]::Load("System.EnterpriseServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")            
$publish = New-Object System.EnterpriseServices.Internal.Publish            
$publish.GacInstall($assemblyPath)  
    
    #"$gacExePath" + " /i " + $assemblyPath  
}

function UninstallAssemblyFromGAC
{
    param([string]$assemblyPath)
    "$gacExePath" + " /i " + $assemblyPath + " /f"
}

#end GAC Functions
#Visual Studio Functions
function BuildVSSolution
{
    param([string]$solutionPath)
    $devEnv = Get-VisualStudioInstallPath | join-path -childpath "devenv.com"
    $buildCommand = "/Build"
    & $devEnv $solutionPath $buildCommand 
    
}

function DeployVSSolution
{
    param([string]$solutionPath)

    $devEnv = Get-VisualStudioInstallPath | join-path -childpath "devenv.com"
    $buildCommand = "/Deploy"
    & $devEnv $solutionPath $buildCommand 
}

#end Visual Studio Functions



#BTS Application Functions

function StopBTSApplication
{ 
	param([string]$appName)

	$btsAdminExe = (Get-FunctionsDirectory | join-path  -childpath "btsadmin.exe")
        $btsCmd = "Stop"
        $btsAppToRemove = $appName

        & $btsAdminExe $btsCmd $btsAppToRemove
}

function StartBTSApplication
{ 
	param([string]$appName)

	$btsAdminExe = (Get-FunctionsDirectory| join-path  -childpath "btsadmin.exe")
        $btsCmd = "Start"
        $btsAppToStart = $appName

        & $btsAdminExe $btsCmd $btsAppToStart

}

function CreateBTSApplication
{
    param([string]$appName)
    
    $btsAdminExe = (Get-FunctionsDirectory | join-path  -childpath "btsadmin.exe")
    $btsCmd = "Create"
    $btsAppToCreate = $appName

    & $btsAdminExe $btsCmd $btsAppToCreate
}

function RemoveBTSApplication
{ 
	param([string]$appName)
      
	$exp = New-Object Microsoft.BizTalk.ExplorerOM.BtsCatalogExplorer
	$exp.ConnectionString = Get-BTSConnectionString
	$app = $exp.Applications[$appName]
	if($app -eq $null)
	{
		Write-Host "Application " $appName " not found" -fore Red
	}
	else
	{
		if($app.Status -ne "Stopped")
		{
			#full stop of application
			StopBTSApplication($appName)
		}

        	#get all of the assemblies from the application and remove them from GAC
		$app.Assemblies | foreach-object {UninstallAssemblyFromGAC $_.Name}

        	#use BTStask to remove the application
        	$btsTaskExe = Get-BTSInstallPath | join-path  -childpath "btstask.exe"
        	$btsCmd = "RemoveApp"
        	$btsAppToRemove = "/ApplicationName:" + $appName
        	& $btsTaskExe $btsCmd $btsAppToRemove
        
        	Write-Host "Removed application: " $appName
	}

}

#end BTS Application Functions


#BTS port functions
function ImportBTSBindingFile
{
    param([string]$bindingFilePath, [string]$appName)
    
     #use BTStask to import the binding file into the application
        $btsTaskExe = Get-BTSInstallPath | join-path  -childpath "btstask.exe"
        $btsCmd = "ImportBindings"
        $btsBindingCmd = "/Source:" + $bindingFilePath
        $btsApp = "/ApplicationName:" + $appName
        & $btsTaskExe $btsCmd $btsBindingCmd $btsApp
}

function EnableReceiveLocation{
	param([string]$locationName)

	$rec = get-wmiobject MSBTS_ReceiveLocation -n root\MicrosoftBizTalkServer -filter "Name='$locationName'"

	if($rec -ne $null)
	{
		if($rec.IsDisabled -eq $true)
		{
			$null =  $rec.Enable()
			Write-Host "Enabled receive location: " + $locationName -fore Green
		}
		else
		{
			Write-Host "Receive location " + $locationName + " is already enabled." -fore Yellow
		}
	}
	else
	{
		Write-Host "Receive location not found" -fore Red 
	}
}

function DisableReceiveLocation{
	param([string]$locationName)

	$rec = get-wmiobject MSBTS_ReceiveLocation -n root\MicrosoftBizTalkServer -filter "Name='$locationName'"

	if($rec -ne $null)
	{
		if($rec.IsDisabled -eq $false)
		{
			$null = $rec.Disable()
			Write-Host "Disabled receive location: " + $locationName -fore Green
		}
		else
		{
			Write-Host "Receive location " + $locationName + " is already disabled." -fore Yellow
		}
	}
	else
	{
		Write-Host "Receive location not found" -fore Red 
	}
}


function StartSendPort{
	param([string]$portName)

	$sp = Get-WmiObject MSBTS_SendPort -n root\MicrosoftBizTalkServer -filter "Name='$portName'"

	if($sp -ne $null)
	{
		if($sp.Status -eq 1 -or $sp.Status -eq 2)
		{
			if($sp.Status -eq 1)
			{
				$null = $sp.Enlist()
			}
			$null = $sp.Start()
			Write-Host "Started send port: " + $portName -fore Green
		}
		else
		{
			Write-Host "Send port " + $portName + " is already started." -fore Yellow
		}
	}
	else
	{
		Write-Host "Send port not found" -fore Red 
	}
}

function UnenlistSendPort{
	param([string]$portName)

	$sp = Get-WmiObject MSBTS_SendPort -n root\MicrosoftBizTalkServer -filter "Name='$portName'"

	if($sp -ne $null)
	{
		if($sp.Status -eq 3 -or $sp.Status -eq 2)
		{
			if($sp.Status -eq 3)
			{
				$null = $sp.Stop()
			}
			$null = $sp.Unenlist()
			Write-Host "Unenlisted send port: " + $portName -fore Green
		}
		else
		{
			Write-Host "Send port " + $portName + " is already unenlisted." -fore Yellow
		}
	}
	else
	{
		Write-Host "Send port not found" -fore Red 
	}
}


function StartOrchestration{
	param([string]$orchName)

	$orch = Get-WmiObject MSBTS_Orchestration -n root\MicrosoftBizTalkServer -filter "Name='$orchName'"

	if($orch -ne $null)
	{
		if($orch.OrchestrationStatus -eq 2 -or $orch.OrchestrationStatus -eq 3)
		{
		
			if($orch.OrchestrationStatus -eq 2)
			{
				$null = $orch.Enlist()
			}
			$null = $orch.Start()
			Write-Host "Started orchestration: " + $orchName -fore Green
		}
		else
		{
			Write-Host "Orchestration " $orchName " is already started." -fore Yellow
		}
	}
	else
	{
		Write-Host "Orchestration not found" -fore Red 
	}
}

function UnenlistOrchestration{
	param([string]$orchName)

	$orch = Get-WmiObject MSBTS_Orchestration -n root\MicrosoftBizTalkServer -filter "Name='$orchName'"

	if($orch -ne $null)
	{
		if($orch.OrchestrationStatus -eq 3 -or $orch.OrchestrationStatus -eq 4)
		{
			if($orch.OrchestrationStatus -eq 4)
			{
				$null = $orch.Stop()
			}
			$null = $orch.Unenlist()
			Write-Host "Unenlisted orchestration: " + $orchName -fore Green
		}
		else
		{
			Write-Host "Orchestration "  $orchName  " is already unenlisted." -fore Yellow
		}
	}
	else
	{
		Write-Host "Orchestration not found" -fore Red 
	}
}


#end BTS port functions



