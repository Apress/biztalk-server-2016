Clear-host
&.\RemoveApp.ps1
&.\InstallApp.ps1

#deleting the output folder
C:\APRESS\Chapter5\PerformanceCounters\BookOrdersSolution\BookOrdersSolution\Ports\DeleteOutputFolder.bat

#testing the solution, sending 10 testing files.
C:\APRESS\Chapter5\PerformanceCounters\BookOrdersSolution\BookOrdersSolution\Ports\Send10VIPBookOrder.bat
pause
