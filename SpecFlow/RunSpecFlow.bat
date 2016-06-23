


"..\packages\NUnit.Runners.2.6.1\tools\nunit-console.exe" /out=TestResult.txt /out=TestResult.xml /framework=net-4.0 bin\Release\SpecFlow.dll
 
"..\packages\SpecFlow.2.1.0\tools\specflow.exe" nunitexecutionreport SpecFlow.csproj
 
IF NOT EXIST TestResult.xml GOTO FAIL
IF NOT EXIST TestResult.html GOTO FAIL
EXIT
 
:FAIL
echo ##teamcity[buildStatus status='FAILURE']
EXIT /B 1

