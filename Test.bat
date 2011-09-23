@echo OFF
.\packages\NUnit.2.5.10.11092\tools\nunit-console.exe .\AllTests.nunit /nologo /labels /process=multiple
del TestResult.xml