#nullable enable

using System.CommandLine;

namespace SiliconFlow.CLI.Commands;

internal sealed record ChatCompletionRequestResponseFormatOptionSet(
    Option<string?> Type)
{
    public static ChatCompletionRequestResponseFormatOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new ChatCompletionRequestResponseFormatOptionSet(
                        Type: new Option<string?>($"--{normalizedPrefix}type")
                {
                    Description = @"The type of the response format.",
                }
        );
    }
}