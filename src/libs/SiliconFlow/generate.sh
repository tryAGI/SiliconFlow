install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

install_autosdk_cli
rm -rf Generated
fetch_spec -o openapi.yaml https://raw.githubusercontent.com/siliconflow/siliconcloud/main/openapi.yaml
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
