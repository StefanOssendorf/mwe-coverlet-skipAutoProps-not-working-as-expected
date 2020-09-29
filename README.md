# Skip auto properties option from coverlet settings do not work as expected


#### How to reproduce
1. dotnet build --force
2. dotnet test --collect:"XPlat Code Coverage" --settings coverletSettings.xml --no-build
3. reportgenerator "-reports:CoverletSkipAutoPropTest_Test\**\*.cobertura.xml" "-targetdir:.\codeCovReport"
   * If you have the report generator tool installed
