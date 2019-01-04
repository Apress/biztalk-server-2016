

function SetPowerPlan([string]$PreferredPlan) 
{ 
    

Try {
    
    Write-Host "Setting Powerplan to $PreferredPlan" 
    $guid = (Get-WmiObject -Class win32_powerplan -Namespace root\cimv2\power -Filter "ElementName='$PreferredPlan'").InstanceID.tostring() 
    $regex = [regex]"{(.*?)}$" 
    $newpowerVal = $regex.Match($guid).groups[1].value

    # setting power setting to high performance 
    powercfg -S  $newpowerVal 

    Write-Host " $PreferredPlan plan set" 

    } Catch {
        Write-Warning -Message "Unable to set power plan to high performance"
    }


}

#set Preferred powerplan 


#valid values are "High performance", "Balanced", "Power saver"
cls
SetPowerPlan "High performance"




