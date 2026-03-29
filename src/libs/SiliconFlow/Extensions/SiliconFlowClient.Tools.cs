#nullable enable

using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace SiliconFlow;

public static class SiliconFlowClientTools
{
    /// <summary>
    /// Creates an AIFunction tool that reranks documents by relevance to a query.
    /// </summary>
    public static AIFunction AsRerankTool(this SiliconFlowClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The search query to rank documents against")] string query,
                   [Description("JSON array of document strings to rerank")] string[] documents,
                   [Description("The reranking model to use (e.g. BAAI/bge-reranker-v2-m3)")] string model = "BAAI/bge-reranker-v2-m3",
                   [Description("Number of top results to return")] int? topN = default,
                   CancellationToken cancellationToken = default) =>
            {
                var response = await client.Rerank.CreateRerankAsync(
                    request: new RerankRequest
                    {
                        Model = RerankRequestModel.BaaiBgeRerankerV2M3,
                        Query = query,
                        Documents = documents,
                        TopN = topN,
                        ReturnDocuments = true,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Id,
                    Results = response.Results.Select(r => new
                    {
                        r.Index,
                        r.RelevanceScore,
                        DocumentText = r.Document?.Text,
                    }).ToArray(),
                    InputTokens = response.Tokens.InputTokens,
                    OutputTokens = response.Tokens.OutputTokens,
                };
            },
            name: "SiliconFlow_Rerank",
            description: "Rerank a list of documents by their relevance to a search query using SiliconFlow's reranking models.");
    }

    /// <summary>
    /// Creates an AIFunction tool that generates images from text prompts.
    /// </summary>
    public static AIFunction AsTextToImageTool(this SiliconFlowClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The text prompt describing the image to generate")] string prompt,
                   [Description("Image size in WIDTHxHEIGHT format (e.g. 1024x1024)")] string imageSize = "1024x1024",
                   CancellationToken cancellationToken = default) =>
            {
                var response = await client.Image.ImageGenerationAsync(
                    request: new Flux1Schnell
                    {
                        Prompt = prompt,
                        ImageSize = Flux1SchnellImageSize.x1024x1024,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    Images = response.Images?.Select(i => i.Url).ToArray(),
                    response.Seed,
                    InferenceTime = response.Timings?.Inference,
                };
            },
            name: "SiliconFlow_TextToImage",
            description: "Generate images from a text prompt using SiliconFlow's image generation models (FLUX, Stable Diffusion).");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists available models.
    /// </summary>
    public static AIFunction AsListModelsTool(this SiliconFlowClient client)
    {
        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.Models.RetrieveAListOfModelsAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    Models = response.Data?.Select(m => new
                    {
                        m.Id,
                        m.OwnedBy,
                    }).ToArray(),
                };
            },
            name: "SiliconFlow_ListModels",
            description: "List all available AI models on the SiliconFlow platform, including text, image, audio, and video models.");
    }

    /// <summary>
    /// Creates an AIFunction tool that gets user account information and balance.
    /// </summary>
    public static AIFunction AsGetUserInfoTool(this SiliconFlowClient client)
    {
        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.UserInfo.UserInfoAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Data?.Name,
                    response.Data?.Email,
                    response.Data?.Balance,
                    response.Data?.ChargeBalance,
                    response.Data?.TotalBalance,
                    response.Data?.Status,
                };
            },
            name: "SiliconFlow_GetUserInfo",
            description: "Get the current user's account information including name, email, balance, and account status.");
    }
}
