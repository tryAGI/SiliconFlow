#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace SiliconFlow.CLI.Commands;

internal static partial class UploadAudioVoiceCommandApiCommand
{
    private static Option<global::SiliconFlow.UploadAudioVoiceRequestModel> Model { get; } = new(
        name: @"--model")
    {
        Description = @"预置音色的模型名称",
    };

    private static Option<string> CustomName { get; } = new(
        name: @"--custom-name")
    {
        Description = @"用户自定义的音色名称",
        DefaultValueFactory = _ => "硅基流动音色模型",
    };

    private static Option<string> Text { get; } = new(
        name: @"--text")
    {
        Description = @"音频对应的文字内容",
        DefaultValueFactory = _ => "在一无所知中, 梦里的一天结束了，一个新的轮回便会开始",
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

                    private static string FormatResponse(ParseResult parseResult, global::SiliconFlow.UploadAudioVoiceResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::SiliconFlow.UploadAudioVoiceResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"upload-audio-voice", @"Upload Voice
上传用户预置音色，支持以 base64 编码或者文件形式上传，参考https://docs.siliconflow.cn/capabilities/text-to-speech#2-2)");
                        command.Options.Add(Model);
                        command.Options.Add(CustomName);
                        command.Options.Add(Text);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::SiliconFlow.UploadAudioVoiceRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::SiliconFlow.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var model = CliRuntime.WasSpecified(parseResult, Model) ? parseResult.GetValue(Model) : (__requestBase is { } __ModelBaseValue ? __ModelBaseValue.Model : default);
                        var customName = parseResult.GetRequiredValue(CustomName);
                        var text = parseResult.GetRequiredValue(Text);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.UploadAudioVoiceAsync(
                                    model: model,
                                    customName: customName,
                                    text: text,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::SiliconFlow.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}