



"..\packages\NUnit.Console.3.0.0\tools\nunit3-console.exe" /out=TestResult.txt /result=TestResult.xml /framework=net-4.5 bin\Release\SpecFlow.dll
 
"..\packages\SpecFlow.2.1.0\tools\specflow.exe" nunitexecutionreport Specflow.csproj
 
IF NOT EXIST TestResult.xml GOTO FAIL
IF NOT EXIST TestResult.html GOTO FAIL
EXIT
 
:FAIL
echo ##teamcity[buildStatus status='FAILURE']
EXIT /B 1

