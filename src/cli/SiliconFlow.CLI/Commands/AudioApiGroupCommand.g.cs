#nullable enable

using System.CommandLine;

namespace SiliconFlow.CLI.Commands;

internal static partial class AudioApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"audio", @"Audio endpoint commands.");
                         command.Subcommands.Add(AudioCreateAudioTranscriptionsCommandApiCommand.Create());
                         command.Subcommands.Add(AudioCreateSpeechCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}