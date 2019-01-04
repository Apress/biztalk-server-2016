cd "C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.6 Tools>"

gacutil /i "C:\Users\Administrator\Documents\BOOK\Module5\PropertyGeneratorPipeline\PropertyGeneratorPipeline\PropertyGeneratorPipeline\bin\Debug\PropertyGeneratorPipeline.dll"

xcopy "C:\Users\Administrator\Documents\BOOK\Module5\PropertyGeneratorPipeline\PropertyGeneratorPipeline\PropertyGeneratorPipeline\bin\Debug\PropertyGeneratorPipeline.dll" "C:\Program Files (x86)\Microsoft BizTalk Server 2016\Pipeline Components"

pause