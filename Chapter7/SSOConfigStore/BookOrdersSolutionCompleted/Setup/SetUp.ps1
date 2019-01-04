Clear-host
&.\RemoveApp.ps1
&.\InstallApp.ps1

#deleting the output folder
C:\BOOK\Module12\SSOConfigStore\BookOrdersSolution\BookOrdersSolution\Ports\DeleteOutputFolder.bat

#testing the solution, sending 10 testing files.
C:\BOOK\Module12\SSOConfigStore\BookOrdersSolution\BookOrdersSolution\Ports\Send10VIPBookOrder.bat
pause
