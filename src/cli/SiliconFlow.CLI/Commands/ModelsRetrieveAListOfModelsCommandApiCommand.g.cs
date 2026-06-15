#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace SiliconFlow.CLI.Commands;

internal static partial class ModelsRetrieveAListOfModelsCommandApiCommand
{
    private static Option<global::SiliconFlow.RetrieveAListOfModelsType?> Type { get; } = new(
        name: @"--type")
    {
        Description = @"The type of models",
    };

    private static Option<global::SiliconFlow.RetrieveAListOfModelsSubType?> SubType { get; } = new(
        name: @"--sub-type")
    {
        Description = @"The sub type of models. You can use it to filter models individually without setting type.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::SiliconFlow.RetrieveAListOfModelsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::SiliconFlow.RetrieveAListOfModelsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"retrieve-alist-of-models", @"Get Model List
Retrieve models information.");
                        command.Options.Add(Type);
                        command.Options.Add(SubType);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var type = parseResult.GetValue(Type);
                        var subType = parseResult.GetValue(SubType);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Models.RetrieveAListOfModelsAsync(
                                    type: type,
                                    subType: subType,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::SiliconFlow.SourceGenerationContext.Default,
                                        @"Data",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::SiliconFlow.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}