/* order: 10, title: Client Creation, slug: client-creation */

namespace SiliconFlow.IntegrationTests.Examples;

[TestClass]
public class ClientCreation
{
    //// SiliconFlow provides a unified AI cloud inference platform with access to
    //// text, image, audio, and video models from multiple providers.

    [TestMethod]
    public void CreateClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("SILICONFLOW_API_KEY") is { Length: > 0 } value
                ? value
                : throw new AssertInconclusiveException("SILICONFLOW_API_KEY environment variable is not found.");

        using var client = new SiliconFlowClient(apiKey);

        //// The client has sub-clients for different API capabilities.
        Assert.IsNotNull(client.ChatCompletions);
        Assert.IsNotNull(client.Embeddings);
        Assert.IsNotNull(client.Rerank);
        Assert.IsNotNull(client.Image);
        Assert.IsNotNull(client.Audio);
        Assert.IsNotNull(client.Models);
        Assert.IsNotNull(client.UserInfo);
    }
}
