# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The SiliconFlow SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to SiliconFlow's document reranking, image generation, model listing, and account information.

## Installation

```bash
dotnet add package SiliconFlow
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsRerankTool()` | `SiliconFlow_Rerank` | Rerank documents by relevance to a search query |
| `AsTextToImageTool()` | `SiliconFlow_TextToImage` | Generate images from text prompts using FLUX/Stable Diffusion models |
| `AsListModelsTool()` | `SiliconFlow_ListModels` | List all available AI models on the platform |
| `AsGetUserInfoTool()` | `SiliconFlow_GetUserInfo` | Get account information including balance and status |

## Usage

```csharp
using SiliconFlow;
using Microsoft.Extensions.AI;

var siliconFlowClient = new SiliconFlowClient(
    apiKey: Environment.GetEnvironmentVariable("SILICONFLOW_API_KEY")!);

var options = new ChatOptions
{
    Tools =
    [
        siliconFlowClient.AsRerankTool(),
        siliconFlowClient.AsTextToImageTool(),
        siliconFlowClient.AsListModelsTool(),
        siliconFlowClient.AsGetUserInfoTool(),
    ],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "What models are available on SiliconFlow?"),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```
