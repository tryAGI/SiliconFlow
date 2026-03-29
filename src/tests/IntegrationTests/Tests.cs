namespace SiliconFlow.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static SiliconFlowClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("SILICONFLOW_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("SILICONFLOW_API_KEY environment variable is not found.");

        var client = new SiliconFlowClient(apiKey);
        
        return client;
    }
}
