# StartInMonitor
Starts applications in a specific monitor. Or in reality it will move the application to the specified monitor/screen after launch. Only works in Windows. Csharp based.

Can be used with a batch file to start multiple applications. In this example it will try and start two Visual Studio solutions in a secondary monitor/screen (hence the number "2"). If the current computer only has one monitor then it will default to that.

Example:

StartSolutions.bat
```
@echo off

StartInMonitor.exe 2 "C:\Users\vindberg\source\repos\Projects\Website\Website.sln" "" 20 60 280 80
StartInMonitor.exe 2 "C:\Users\vindberg\source\repos\Projects\StartInMonitor\StartInMonitor.sln" "" 80 60 280 80
```

