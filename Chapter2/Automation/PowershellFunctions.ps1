
[void] [System.reflection.Assembly]::LoadWithPartialName("Microsoft.BizTalk.ExplorerOM")


function AddHost(
    [string]$host, 
    [int]$hostType, 
    [string]$ADGroupName, 
    [bool]$trustedAuthentication, 
    [bool]$TrackingHost, 
    [bool]$32BitOnly)
{
    try
    {
        
        #Loading the MSBTS_HostSetting WMI class
        [System.Management.ManagementObject]$objHostSetting = ([WmiClass]"root/MicrosoftBizTalkServer:MSBTS_HostSetting").CreateInstance()

        #Setting the parameters for host creation
        $objHostSetting["Name"] = $host
        $objHostSetting["HostType"] = $hostType
        $objHostSetting["NTGroupName"] = $ADGroupName
        $objHostSetting["AuthTrusted"] = $trustedAuthentication
        $objHostSetting["IsHost32BitOnly"] = $32BitOnly 
        $objHostSetting["HostTracking"] = $TrackingHost

        #Loading the PutType options for the Invoke method. This will tell WMI that the settings should be added as a new host. 
        $putOptions = new-Object System.Management.PutOptions
        $putOptions.Type = [System.Management.PutType]::CreateOnly;

        [Type[]] $targetTypes = New-Object System.Type[] 1
        $targetTypes[0] = $putOptions.GetType()

        #loading the BizTalk Server management operations from Microsoft.BizTalk.ExplorerOM")
        $sysMgmtAssemblyName = "System.Management"
        $sysMgmtAssembly = [System.Reflection.Assembly]::LoadWithPartialName($sysMgmtAssemblyName)
        $objHostSettingType = $sysMgmtAssembly.GetType("System.Management.ManagementObject")

        
        [Reflection.MethodInfo] $methodInfo = $objHostSettingType.GetMethod("Put", $targetTypes)
        #Calling an Invoke with the Put options. in this case: CreateOnly. 
        $methodInfo.Invoke($objHostSetting, $putOptions)
		
		Write-Host "Host $host was successfully created" -Fore DarkGreen
    }
    catch [System.Management.Automation.RuntimeException]
    {
		
        write-Error "$host host could not be created: $_.Exception.ToString()"
		
    }
}

function SetHost ( 
    [string]$host, 
    [int]$hostType, 
    [string]$ADGroupName, 
    [bool]$trustedAuthentication, 
    [bool]$TrackingHost, 
    [bool]$32BitOnly,
	[bool]$isDefaultHost)
{
    try
    {
        #Loading the MSBTS_HostSetting WMI class
        [System.Management.ManagementObject]$objHostSetting = ([WmiClass]"root/MicrosoftBizTalkServer:MSBTS_HostSetting").CreateInstance()

        #Setting the parametrs for host update
        $objHostSetting["Name"] = $host
        $objHostSetting["HostType"] = $hostType
        $objHostSetting["NTGroupName"] = $ADGroupName
        $objHostSetting["AuthTrusted"] = $trustedAuthentication
        $objHostSetting["IsHost32BitOnly"] = $32BitOnly 
        $objHostSetting["HostTracking"] = $TrackingHost
		$objHostSetting["IsDefault"] = $isDefaultHost

        #Loading the PutType options for the Invoke method. This will tell WMI that the settings should be considered as an update for a host. 
       
        $putOptions = new-Object System.Management.PutOptions
        $putOptions.Type = [System.Management.PutType]::UpdateOnly; # This tells WMI it's an update.

        [Type[]] $targetTypes = New-Object System.Type[] 1
        $targetTypes[0] = $putOptions.GetType()

        #loading the BizTalk Server management operations from Microsoft.BizTalk.ExplorerOM")
        $sysMgmtAssemblyName = "System.Management"
        $sysMgmtAssembly = [System.Reflection.Assembly]::LoadWithPartialName($sysMgmtAssemblyName)
        $objHostSettingType = $sysMgmtAssembly.GetType("System.Management.ManagementObject")

        #Calling an Invoke with the Put options. in this case: CreateOnly. 
        [Reflection.MethodInfo] $methodInfo = $objHostSettingType.GetMethod("Put", $targetTypes)
        $methodInfo.Invoke($objHostSetting, $putOptions)
		
		Write-Host "Host $host was successfully updated" -Fore DarkGreen
    }
    catch [System.Management.Automation.RuntimeException]
    {
        write-Error "$host host could not be updated: $_.Exception.ToString()"
    }
}


function SetHostInstanceForLowLatency ( 
    [string]$hostInstance)
    
{

[void] [System.reflection.Assembly]::LoadWithPartialName("Microsoft.BizTalk.ExplorerOM")

    try
    {
        #Loading the MSBTS_HostSetting WMI class
        [System.Management.ManagementObject]$objHostInstanceSetting = ([WmiClass]"root/MicrosoftBizTalkServer:MSBTS_HostInstanceSetting")

        #Setting the parametrs for host update
        $objHostInstanceSetting["Name"] = $hostInstance
        $objHostInstanceSetting["CLRMaxIOThreads"] = 250
        $objHostInstanceSetting["CLRMaxWorkerThreads"] = 250
        $objHostInstanceSetting["CLRMinIOThreads"] = 25
        $objHostInstanceSetting["CLRMinWorkerThreads"] = 25
        

        #Loading the PutType options for the Invoke method. This will tell WMI that the settings should be considered as an update for a host. 
       
        $putOptions = new-Object System.Management.PutOptions
        $putOptions.Type = [System.Management.PutType]::UpdateOnly; # This tells WMI it's an update.

        [Type[]] $targetTypes = New-Object System.Type[] 1
        $targetTypes[0] = $putOptions.GetType()

        #loading the BizTalk Server management operations from Microsoft.BizTalk.ExplorerOM")
        $sysMgmtAssemblyName = "System.Management"
        $sysMgmtAssembly = [System.Reflection.Assembly]::LoadWithPartialName($sysMgmtAssemblyName)
        $objHostSettingType = $sysMgmtAssembly.GetType("System.Management.ManagementObject")

        #Calling an Invoke with the Put options. in this case: CreateOnly. 
        [Reflection.MethodInfo] $methodInfo = $objHostInstanceSetting.GetMethod("Put", $targetTypes)
        $methodInfo.Invoke($objHostSetting, $putOptions)
		
		Write-Host "Host instance $hostInstance  was successfully tunned for low latency" -Fore DarkGreen
    }
    catch [System.Management.Automation.RuntimeException]
    {
        write-Error "$host host inst could not be updated: $_.Exception.ToString()"
    }
}

function SetHostToLowLatency ( 
    [string]$host, 
    [int]$DBQueueSizeThreshold = 100000, 
    [int]$DehydrationBehavior = 0, 
    [int]$DeliveryQueueSize =5000, 
    [int]$GlobalMemoryThreshold = 100, 
    [int]$inflightMessageThreshold=5000, 
    [int]$MessageDeliveryOverdriveFactor= 0, 
    [int]$MessagePublishOverdriveFactor = 0, 
    [int]$MessagingMaxReceiveInterval = 25, 
    [int]$XlangMaxReceiveInterval=25, 
    [int]$ProcessMemoryThreshold= 100, 
    [int]$ThreadThreshold = 0)
{
    try
    {
        #Loading the MSBTS_HostSetting WMI class
        [System.Management.ManagementObject]$objHostSetting = ([WmiClass]"root/MicrosoftBizTalkServer:MSBTS_HostSetting").CreateInstance()

        #Setting the parametrs for low latency host update
        $objHostSetting["Name"] = $host
        $objHostSetting["DBQueueSizeThreshold"] =$DBQueueSizeThreshold
        $objHostSetting["DehydrationBehavior"] =$DehydrationBehavior 
        $objHostSetting["DeliveryQueueSize"] =$DeliveryQueueSize
        $objHostSetting["GlobalMemoryThreshold"] =$GlobalMemoryThreshold
        $objHostSetting["inflightMessageThreshold"] =$inflightMessageThreshold
        $objHostSetting["MessageDeliveryOverdriveFactor"] =$MessageDeliveryOverdriveFactor
        $objHostSetting["MessagePublishOverdriveFactor"] =$MessagePublishOverdriveFactor 
        $objHostSetting["MessagingMaxReceiveInterval"] =$MessagingMaxReceiveInterval
        $objHostSetting["XlangMaxReceiveInterval"] =$XlangMaxReceiveInterval
        $objHostSetting["ProcessMemoryThreshold"] =$ProcessMemoryThreshold 
        $objHostSetting["ThreadThreshold"] =$ThreadThreshold
        

        #Loading the PutType options for the Invoke method. This will tell WMI that the settings should be considered as an update for a host. 
       
        $putOptions = new-Object System.Management.PutOptions
        $putOptions.Type = [System.Management.PutType]::UpdateOnly; # This tells WMI it's an update.

        [Type[]] $targetTypes = New-Object System.Type[] 1
        $targetTypes[0] = $putOptions.GetType()

        #loading the BizTalk Server management operations from Microsoft.BizTalk.ExplorerOM")
        $sysMgmtAssemblyName = "System.Management"
        $sysMgmtAssembly = [System.Reflection.Assembly]::LoadWithPartialName($sysMgmtAssemblyName)
        $objHostSettingType = $sysMgmtAssembly.GetType("System.Management.ManagementObject")

        #Calling an Invoke with the Put options. in this case: CreateOnly. 
        [Reflection.MethodInfo] $methodInfo = $objHostSettingType.GetMethod("Put", $targetTypes)
        $methodInfo.Invoke($objHostSetting, $putOptions)
		
		Write-Host "Host $host was successfully updated" -Fore DarkGreen
    }
    catch [System.Management.Automation.RuntimeException]
    {
        write-Error "$host host could not be updated for low latency: $_.Exception.ToString()"
    }
}


function AddHostInstance(
	[string]$hostName,
	[string]$serverName,
	[string]$username,
	[string]$password)
{
    try
    {
        #Loading the MSBTS_ServerHost WMI class
        
        [System.Management.ManagementObject]$ServerHostWMI = ([WmiClass]"root/MicrosoftBizTalkServer:MSBTS_ServerHost").CreateInstance()

        #Setting the properties of the host instance. 
        $ServerHostWMI["HostName"] = $hostName
        $ServerHostWMI["ServerName"] = $serverName
        #linking the configuration to that host
        $ServerHostWMI.Map() 

        #Loading the MSBTS_HostInstance WMI class

        [System.Management.ManagementObject]$HostInstanceWMI = ([WmiClass]"root/MicrosoftBizTalkServer:MSBTS_HostInstance").CreateInstance()

        #Temporary holder to construct the host instance name, the string "Microsoft BizTalk Server" is mandatory if not the creation will fail. 
        $nameTmp = "Microsoft BizTalk Server " + $hostName + " " + $serverName
        $HostInstanceWMI["Name"] = $nameTmp
        $HostInstanceWMI.Install($username, $password, $true)

		Write-Host "HostInstance $hosthostName installed" -Fore DarkGreen
    }
    catch [System.Management.Automation.RuntimeException]
    {
	
	   write-Error "$hostName host instance on server $Server could not be created: $_.Exception.ToString()"
		
    }
}


function DeleteBizTalkAdapterHandler (
	[string]$adapterName,
	[string]$direction,
	[string]$host)
{
	try
    {
		if($direction -eq 'Receive')
		{
			[System.Management.ManagementObject]$objHandler = get-wmiobject 'MSBTS_ReceiveHandler' -namespace 'root\MicrosoftBizTalkServer' -filter "HostName='$host' AND AdapterName='$adapterName'"
	        $objHandler.Delete()
		}
		else
		{
			[System.Management.ManagementObject]$objHandler = get-wmiobject 'MSBTS_SendHandler2' -namespace 'root\MicrosoftBizTalkServer' -filter "HostName='$host' AND AdapterName='$adapterName'"
	        $objHandler.Delete()
		}
    
		Write-Host "$direction handler for $adapterName / $host was successfully deleted" -Fore DarkGreen
    }
    catch [System.Management.Automation.RuntimeException]
    {
        if ($_.Exception.Message -eq "You cannot call a method on a null-valued expression.")
        {
			Write-Host "$adapterName $direction Handler for $host does not exist" -Fore DarkRed
        }
        elseif ($_.Exception.Message.IndexOf("Cannot delete a receive handler that is used by") -ne -1)
        {
			Write-Host "$adapterName $direction Handler for $host is in use and can't be deleted." -Fore DarkRed
        }
		elseif ($_.Exception.Message.IndexOf("Cannot delete a send handler that is used by") -ne -1)
        {
			Write-Host "$adapterName $direction Handler for $host is in use and can't be deleted." -Fore DarkRed
        }
		elseif ($_.Exception.Message.IndexOf("Cannot delete this object since at least one receive location is associated with it") -ne -1)
        {
			Write-Host "$adapterName $direction Handler for $host is in use by at least one receive location and can't be deleted." -Fore DarkRed
        }
        else
        {
            write-Error "$adapterName $direction Handler for $host could not be deleted: $_.Exception.ToString()"
        }
    }
}




function SetInitialSeparationPolicy
{
	[string]$trackingHost= 'trackingHost'	
    [string]$processingHost64 = 'processingHost64'
    [string]$processingHost32 = 'processingHost32'
	[string]$receivingHost64 = 'receivingHost64'  
	[string]$sendingHost64 = 'sendingHost64'
	[string]$receivingHost32 = 'receivingHost32'
	[string]$sendingHost32 = 'sendingHost32'
	[string]$defaultHostName = 'BizTalkServerApplication'
    [string] $hostInstanceUser = 'Administrator' #type here the user name that will run the hostInstance.
    [string] $hostInstancePassword = 'Password' #Type here the password of the previous user name.
    [string]$ADHostGroupName = 'BizTalk Application Users' #Type here the AD users group for host instances.
    
    #adding the tracking host
	AddHost $trackingHost 1 $ADHostGroupName $false $true $false
    # Adding the host instance for tracking
	AddHostInstance $trackingHost$bizTalkServerName $hostInstanceUser $hostInstancePassword
    # Set "Allow Host Tracking" options from BizTalkServerApplication Host
	SetHost $trackingHost 1 $ADHostGroupName $false $false $true $true		
	# Remove "Allow Host Tracking" options from BizTalkServerApplication Host
	SetHost $defaultHostName 1 $ADHostGroupName $false $false $true $true
    
    #Adding the receiving hosts
	AddHost $receivingHost64 1 $ADHostGroupName $false $false $false
	AddHost $receivingHost32 1 $ADHostGroupName $false $false $true
 
	# Adding the receiving hostinstances 
	AddHostInstance $receivingHost64 $bizTalkServerName $hostInstanceUser $hostInstancePassword
	AddHostInstance $receivingHost32 $bizTalkServerName $hostInstanceUser $hostInstancePassword
  
    #Adding the sending hosts
	AddHost $sendingHost64 1 $ADHostGroupName $false $false $false
	AddHost $sendingHost32 1 $ADHostGroupName $false $false $true
 
    #Adding the sending host instances
	AddHostInstance $sendingHost64 $bizTalkServerName $hostInstanceUser $hostInstancePassword
	AddHostInstance $sendingHost32 $bizTalkServerName $hostInstanceUser $hostInstancePassword 
	
		
	#Adding the hosts for processing orchestrations
	AddHost $processingHost64 1 $ADHostGroupName $false $false $false
    AddHost $processingHost32 1 $ADHostGroupName $false $false $false
 
	# Adding the host instances for processing orchestrations
	AddHostInstance $processingHost64 $bizTalkServerName $hostInstanceUser $hostInstancePassword
    AddHostInstance $processingHost32 $bizTalkServerName $hostInstanceUser $hostInstancePassword 
	
	}
