#nullable enable

using System.CommandLine;

namespace SiliconFlow.CLI.Commands;

internal sealed record ChatCompletionRequestOptionSet(
    Option<global::SiliconFlow.ChatCompletionRequestModel> Model,
                     Option<bool?> Stream,
                     Option<int?> MaxTokens,
                     Option<float?> Temperature,
                     Option<float?> TopP,
                     Option<float?> TopK,
                     Option<float?> FrequencyPenalty,
                     Option<int?> N)
{
    public static ChatCompletionRequestOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new ChatCompletionRequestOptionSet(
                        Model: new Option<global::SiliconFlow.ChatCompletionRequestModel>($"--{normalizedPrefix}model")
                {
                    Description = @"The name of the model to query.",
                    DefaultValueFactory = _ => global::SiliconFlow.ChatCompletionRequestModel.DeepseekAiDeepSeekV25,
                },
                Stream: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}stream", description: @"If set, tokens are returned as Server-Sent Events as they are made available. Stream terminates with `data: [DONE]`"),
                MaxTokens: new Option<int?>($"--{normalizedPrefix}max-tokens")
                {
                    Description = @"The maximum number of tokens to generate.",
                },
                Temperature: new Option<float?>($"--{normalizedPrefix}temperature")
                {
                    Description = @"Determines the degree of randomness in the response.",
                },
                TopP: new Option<float?>($"--{normalizedPrefix}top-p")
                {
                    Description = @"The `top_p` (nucleus) parameter is used to dynamically adjust the number of choices for each predicted token based on the cumulative probabilities.",
                },
                TopK: new Option<float?>($"--{normalizedPrefix}top-k")
                {
                    Description = @"",
                },
                FrequencyPenalty: new Option<float?>($"--{normalizedPrefix}frequency-penalty")
                {
                    Description = @"",
                },
                N: new Option<int?>($"--{normalizedPrefix}n")
                {
                    Description = @"Number of generations to return",
                }
        );
    }
}