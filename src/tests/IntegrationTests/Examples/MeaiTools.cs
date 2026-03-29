/* order: 20, title: MEAI Tools, slug: meai-tools */

namespace SiliconFlow.IntegrationTests.Examples;

[TestClass]
public class MeaiTools
{
    //// SiliconFlow provides `AIFunction` tools that can be used with any `IChatClient`
    //// for function/tool calling scenarios.

    [TestMethod]
    public void CreateTools()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("SILICONFLOW_API_KEY") is { Length: > 0 } value
                ? value
                : throw new AssertInconclusiveException("SILICONFLOW_API_KEY environment variable is not found.");

        using var client = new SiliconFlowClient(apiKey);

        //// Create tools for reranking, image generation, model listing, and account info.
        var rerankTool = client.AsRerankTool();
        var textToImageTool = client.AsTextToImageTool();
        var listModelsTool = client.AsListModelsTool();
        var getUserInfoTool = client.AsGetUserInfoTool();

        Assert.AreEqual("SiliconFlow_Rerank", rerankTool.Name);
        Assert.AreEqual("SiliconFlow_TextToImage", textToImageTool.Name);
        Assert.AreEqual("SiliconFlow_ListModels", listModelsTool.Name);
        Assert.AreEqual("SiliconFlow_GetUserInfo", getUserInfoTool.Name);

        //// These tools can be passed to any IChatClient that supports function calling.
        var tools = new[] { rerankTool, textToImageTool, listModelsTool, getUserInfoTool };
        Assert.AreEqual(4, tools.Length);
    }
}
