#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace SiliconFlow.CLI.Commands;

internal static partial class ChatCompletionsChatCompletionsCommandApiCommand
{
    private static Option<global::System.Collections.Generic.IList<global::SiliconFlow.ChatCompletionRequestMessage>> Messages { get; } = new(
        name: @"--messages")
    {
        Description = @"A list of messages comprising the conversation so far.",
        Required = true,
    };

    private static Option<global::SiliconFlow.OneOf<string, global::System.Collections.Generic.IList<string>>?> Stop { get; } = new(
        name: @"--stop")
    {
        Description = @"Up to 4 sequences where the API will stop generating further tokens. The returned text will not contain the stop sequence.
",
    };
    private static readonly ChatCompletionRequestOptionSet ChatCompletionRequestOptionSetOptions = ChatCompletionRequestOptionSet.Create();

    private static readonly ChatCompletionRequestResponseFormatOptionSet ResponseFormatOptions = ChatCompletionRequestResponseFormatOptionSet.Create(@"response-format");
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::SiliconFlow.ChatCompletionResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::SiliconFlow.ChatCompletionResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"chat-completions", @"Chat Completions
Creates a model response for the given chat conversation.");
                        command.Options.Add(Messages);
                        command.Options.Add(Stop);                        command.Options.Add(ChatCompletionRequestOptionSetOptions.Model);
                        command.Options.Add(ChatCompletionRequestOptionSetOptions.MaxTokens);
                        command.Options.Add(ChatCompletionRequestOptionSetOptions.Temperature);
                        command.Options.Add(ChatCompletionRequestOptionSetOptions.TopP);
                        command.Options.Add(ChatCompletionRequestOptionSetOptions.TopK);
                        command.Options.Add(ChatCompletionRequestOptionSetOptions.FrequencyPenalty);
                        command.Options.Add(ChatCompletionRequestOptionSetOptions.N);                        command.Options.Add(ResponseFormatOptions.Type);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::SiliconFlow.ChatCompletionRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::SiliconFlow.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var messages = parseResult.GetRequiredValue(Messages);
                        var stop = CliRuntime.WasSpecified(parseResult, Stop) ? parseResult.GetValue(Stop) : (__requestBase is { } __StopBaseValue ? __StopBaseValue.Stop : default);                        var model = parseResult.GetRequiredValue(ChatCompletionRequestOptionSetOptions.Model);
                        var maxTokens = CliRuntime.WasSpecified(parseResult, ChatCompletionRequestOptionSetOptions.MaxTokens) ? parseResult.GetValue(ChatCompletionRequestOptionSetOptions.MaxTokens) : (__requestBase is { } __MaxTokensBaseValue ? __MaxTokensBaseValue.MaxTokens : default);
                        var temperature = CliRuntime.WasSpecified(parseResult, ChatCompletionRequestOptionSetOptions.Temperature) ? parseResult.GetValue(ChatCompletionRequestOptionSetOptions.Temperature) : (__requestBase is { } __TemperatureBaseValue ? __TemperatureBaseValue.Temperature : default);
                        var topP = CliRuntime.WasSpecified(parseResult, ChatCompletionRequestOptionSetOptions.TopP) ? parseResult.GetValue(ChatCompletionRequestOptionSetOptions.TopP) : (__requestBase is { } __TopPBaseValue ? __TopPBaseValue.TopP : default);
                        var topK = CliRuntime.WasSpecified(parseResult, ChatCompletionRequestOptionSetOptions.TopK) ? parseResult.GetValue(ChatCompletionRequestOptionSetOptions.TopK) : (__requestBase is { } __TopKBaseValue ? __TopKBaseValue.TopK : default);
                        var frequencyPenalty = CliRuntime.WasSpecified(parseResult, ChatCompletionRequestOptionSetOptions.FrequencyPenalty) ? parseResult.GetValue(ChatCompletionRequestOptionSetOptions.FrequencyPenalty) : (__requestBase is { } __FrequencyPenaltyBaseValue ? __FrequencyPenaltyBaseValue.FrequencyPenalty : default);
                        var n = CliRuntime.WasSpecified(parseResult, ChatCompletionRequestOptionSetOptions.N) ? parseResult.GetValue(ChatCompletionRequestOptionSetOptions.N) : (__requestBase is { } __NBaseValue ? __NBaseValue.N : default);

                        var __responseFormatBase = __requestBase is { } __ResponseFormatBaseValue ? __ResponseFormatBaseValue.ResponseFormat : default;                        var responseFormatType = CliRuntime.WasSpecified(parseResult, ResponseFormatOptions.Type) ? parseResult.GetValue(ResponseFormatOptions.Type) : (__responseFormatBase is { } __ResponseFormattypeBaseValue ? __ResponseFormattypeBaseValue.Type : default);
                        var __responseFormatSpecified = CliRuntime.WasSpecified(parseResult, ResponseFormatOptions.Type);
                        var responseFormat =
                            __responseFormatSpecified || __responseFormatBase is not null
                                ? new global::SiliconFlow.ChatCompletionRequestResponseFormat
                                {
	                                Type = responseFormatType,

                                }
                                : __responseFormatBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ChatCompletions.ChatCompletionsAsync(
                                    messages: messages,
                                    stop: stop,
                                    model: model,
                                    maxTokens: maxTokens,
                                    temperature: temperature,
                                    topP: topP,
                                    topK: topK,
                                    frequencyPenalty: frequencyPenalty,
                                    n: n,
                                    responseFormat: responseFormat,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::SiliconFlow.SourceGenerationContext.Default,
                                        @"Choices",
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