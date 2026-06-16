#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace SiliconFlow.CLI.Commands;

internal static partial class AudioCreateSpeechCommandApiCommand
{
    private static Option<global::SiliconFlow.CreateSpeechRequestModel> Model { get; } = new(
        name: @"--model")
    {
        Description = @"Current available TTS models: `fishaudio/fish-speech-1.4`
",
    };

    private static Option<string> InputOption { get; } = new(
        name: @"--input")
    {
        Description = @"The text to generate audio for.",
        Required = true,
    };

    private static Option<global::SiliconFlow.CreateSpeechRequestVoice> Voice { get; } = new(
        name: @"--voice")
    {
        Description = @"The voice to use when generating the audio. Supported voices are `fishaudio/fish-speech-1.4:alex`, `fishaudio/fish-speech-1.4:anna`, `fishaudio/fish-speech-1.4:bella`, `fishaudio/fish-speech-1.4:benjamin`, `fishaudio/fish-speech-1.4:charles`, `fishaudio/fish-speech-1.4:claire`, `fishaudio/fish-speech-1.4:david`, `fishaudio/fish-speech-1.4:diana`. Previews of the voices are available in the [Text to speech guide](/capabilities/text-to-speech).",
        Required = true,
    };

    private static Option<global::SiliconFlow.CreateSpeechRequestResponseFormat?> ResponseFormat { get; } = new(
        name: @"--response-format")
    {
        Description = @"The format to audio in. Supported formats are `mp3`, `opus`, `wav`, `pcm`",
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

    public static Command Create()
    {
        var command = new Command(@"create-speech", @"Create Speech
从输入文本生成音频。根据输入的文本生成音频。接口生成的数据为音频的二进制数据，需要使用者自行处理。参考：https://docs.siliconflow.cn/capabilities/text-to-speech#5");
                        command.Options.Add(Model);
                        command.Options.Add(InputOption);
                        command.Options.Add(Voice);
                        command.Options.Add(ResponseFormat);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::SiliconFlow.CreateSpeechRequest>(
                            parseResult,
                            RequestInput,
                            RequestJson,
                            RequestFile,
                            global::SiliconFlow.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var model = CliRuntime.WasSpecified(parseResult, Model) ? parseResult.GetValue(Model) : (__requestBase is { } __ModelBaseValue ? __ModelBaseValue.Model : default);
                        var input = parseResult.GetRequiredValue(InputOption);
                        var voice = parseResult.GetRequiredValue(Voice);
                        var responseFormat = CliRuntime.WasSpecified(parseResult, ResponseFormat) ? parseResult.GetValue(ResponseFormat) : (__requestBase is { } __ResponseFormatBaseValue ? __ResponseFormatBaseValue.ResponseFormat : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Audio.CreateSpeechAsync(
                                    model: model,
                                    input: input,
                                    voice: voice,
                                    responseFormat: responseFormat,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteBinaryAsync(parseResult, response, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}