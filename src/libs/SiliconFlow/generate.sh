dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://raw.githubusercontent.com/siliconflow/siliconcloud/main/openapi.yaml
autosdk generate openapi.yaml \
  --namespace SiliconFlow \
  --clientClassName SiliconFlowClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer

rm -rf ../../cli/SiliconFlow.CLI

autosdk cli-project openapi.yaml \
  --output ../../cli/SiliconFlow.CLI \
  --sdk-project ../../libs/SiliconFlow/SiliconFlow.csproj \
  --targetFramework net10.0 \
  --namespace SiliconFlow \
  --clientClassName SiliconFlowClient \
  --package-id SiliconFlow.CLI \
  --tool-command-name silicon-flow \
  --user-secrets-id SiliconFlow.CLI \
  --api-key-env-var SILICONFLOW_API_KEY \
  --base-url-env-var SILICONFLOW_BASE_URL \
  --cli-credential-file \
  --cli-keep-api-group \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
