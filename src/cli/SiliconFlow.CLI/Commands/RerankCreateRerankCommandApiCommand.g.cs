#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace SiliconFlow.CLI.Commands;

internal static partial class RerankCreateRerankCommandApiCommand
{
    private static Option<global::SiliconFlow.RerankRequestModel> Model { get; } = new(
        name: @"--model")
    {
        Description = @"Specifies the model to be used.",
        Required = true,
    };

    private static Option<string> Query { get; } = new(
        name: @"--query")
    {
        Description = @"Required. The search query.",
        DefaultValueFactory = _ => "Apple",
    };

    private static Option<global::System.Collections.Generic.IList<string>> Documents { get; } = new(
        name: @"--documents")
    {
        Description = @"Required. List of documents to be reordered. If document objects are provided, the 'text' field is mandatory, and other fields will be preserved in the response.",
        Required = true,
    };

    private static Option<int?> TopN { get; } = new(
        name: @"--top-n")
    {
        Description = @"Number of most relevant documents or indices to return.",
    };

    private static Option<bool?> ReturnDocuments { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--return-documents",
        description: @"If false, the response does not include document text; if true, it includes the input document text.");

    private static Option<int?> MaxChunksPerDoc { get; } = new(
        name: @"--max-chunks-per-doc")
    {
        Description = @"Maximum number of chunks generated from within a document. Long documents are divided into multiple chunks for calculation, and the highest score among the chunks is taken as the document's score.",
    };

    private static Option<int?> OverlapTokens { get; } = new(
        name: @"--overlap-tokens")
    {
        Description = @"Number of token overlaps between adjacent chunks when documents are chunked.",
    };
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

                    private static string FormatResponse(ParseResult parseResult, global::SiliconFlow.RerankResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::SiliconFlow.RerankResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-rerank", @"Create Rerank
Creates a rerank request.");
                        command.Options.Add(Model);
                        command.Options.Add(Query);
                        command.Options.Add(Documents);
                        command.Options.Add(TopN);
                        command.Options.Add(ReturnDocuments);
                        command.Options.Add(MaxChunksPerDoc);
                        command.Options.Add(OverlapTokens);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::SiliconFlow.RerankRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::SiliconFlow.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var model = parseResult.GetRequiredValue(Model);
                        var query = parseResult.GetRequiredValue(Query);
                        var documents = parseResult.GetRequiredValue(Documents);
                        var topN = CliRuntime.WasSpecified(parseResult, TopN) ? parseResult.GetValue(TopN) : (__requestBase is { } __TopNBaseValue ? __TopNBaseValue.TopN : default);
                        var returnDocuments = CliRuntime.WasSpecified(parseResult, ReturnDocuments) ? parseResult.GetValue(ReturnDocuments) : (__requestBase is { } __ReturnDocumentsBaseValue ? __ReturnDocumentsBaseValue.ReturnDocuments : default);
                        var maxChunksPerDoc = CliRuntime.WasSpecified(parseResult, MaxChunksPerDoc) ? parseResult.GetValue(MaxChunksPerDoc) : (__requestBase is { } __MaxChunksPerDocBaseValue ? __MaxChunksPerDocBaseValue.MaxChunksPerDoc : default);
                        var overlapTokens = CliRuntime.WasSpecified(parseResult, OverlapTokens) ? parseResult.GetValue(OverlapTokens) : (__requestBase is { } __OverlapTokensBaseValue ? __OverlapTokensBaseValue.OverlapTokens : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Rerank.CreateRerankAsync(
                                    model: model,
                                    query: query,
                                    documents: documents,
                                    topN: topN,
                                    returnDocuments: returnDocuments,
                                    maxChunksPerDoc: maxChunksPerDoc,
                                    overlapTokens: overlapTokens,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::SiliconFlow.SourceGenerationContext.Default,
                                        @"Results",
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