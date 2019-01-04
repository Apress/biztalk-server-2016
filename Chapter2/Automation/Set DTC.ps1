

Function setDTC {

Write-Host "Enabling MSDTC for Network Access..." –fore green

try {
    Set-DtcNetworkSetting –DtcName Local –AuthenticationLevel Mutual –InboundTransactionsEnabled 1 –OutboundTransactionsEnabled 1 –RemoteClientAccessEnabled 1 –confirm:$false

    Restart-Service MSDTC

    Write-Host "`nMSDTC has been configured and restarted"
}
catch {
    Write-Host "MSDTC setup failed" -fore red
}

}

setDTC 