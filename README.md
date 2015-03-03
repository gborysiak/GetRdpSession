# GetRdpSession
Small application for listing Remote Desktop session

Based on code published in Stackoverflow http://stackoverflow.com/questions/13987213/c-sharp-get-rdc-rdp-and-console-session-information

Developped with Visual Studio 2013 and .Net 4.5 framework

Example :
FOR /f "tokens=1" %%i in ('GetRdpSession.exe  %COMPUTERNAME% ^| find "Disconnected"') do rwinsta %%i /SERVER:%COMPUTERNAME% /V
