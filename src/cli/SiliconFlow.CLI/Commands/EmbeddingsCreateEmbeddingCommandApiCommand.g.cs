#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace SiliconFlow.CLI.Commands;

internal static partial class EmbeddingsCreateEmbeddingCommandApiCommand
{
    private static Option<global::SiliconFlow.EmbeddingsRequestModel> Model { get; } = new(
        name: @"--model")
    {
        Description = @"The name of the embedding model to use.要使用的 embedding 模型名称。",
        Required = true,
    };

    private static Option<global::SiliconFlow.OneOf<string, global::System.Collections.Generic.IList<string>>> InputOption { get; } = new(
        name: @"--input")
    {
        Description = @"Input text to embed, encoded as a string or array of tokens. To embed multiple inputs in a single request, pass an array of strings or array of token arrays. The input must not exceed the max input tokens for the model (512 tokens for all models except BAAI/bge-m3 which is 8192), cannot be an empty string.
输入的文本将被编码为字符串或 tokens 数组。要在单个请求中嵌入多个输入，请传递字符串数组或字符串数组。每个字符串不得超过模型的最大 tokens 限制（BAAI/bge-m3模型为8192tokens，其余模型为512tokens），且不能为空字符串。
",
        Required = true,
    };

    private static Option<global::SiliconFlow.EmbeddingsRequestEncodingFormat?> EncodingFormat { get; } = new(
        name: @"--encoding-format")
    {
        Description = @"""The format to return the embeddings in. Can be either `float` or [`base64`](https://pypi.org/project/pybase64/). 返回嵌入的格式。可以是 float 或 [`base64`](https://pypi.org/project/pybase64/).""
",
    };
      private static Option<string?> RequestInput { get; } = new(@"--request-input")
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

                    private static string FormatResponse(ParseResult parseResult, global::SiliconFlow.EmbeddingsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::SiliconFlow.EmbeddingsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-embedding", @"Create Embeddings
Creates an embedding vector representing the input text.");
                        command.Options.Add(Model);
                        command.Options.Add(InputOption);
                        command.Options.Add(EncodingFormat);
          command.Options.Add(RequestInput);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(RequestInput) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --request-input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::SiliconFlow.EmbeddingsRequest>(
                            parseResult,
                            RequestInput,
                            RequestJson,
                            RequestFile,
                            global::SiliconFlow.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var model = parseResult.GetRequiredValue(Model);
                        var input = parseResult.GetRequiredValue(InputOption);
                        var encodingFormat = CliRuntime.WasSpecified(parseResult, EncodingFormat) ? parseResult.GetValue(EncodingFormat) : (__requestBase is { } __EncodingFormatBaseValue ? __EncodingFormatBaseValue.EncodingFormat : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Embeddings.CreateEmbeddingAsync(
                                    model: model,
                                    input: input,
                                    encodingFormat: encodingFormat,
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