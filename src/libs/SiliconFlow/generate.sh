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
