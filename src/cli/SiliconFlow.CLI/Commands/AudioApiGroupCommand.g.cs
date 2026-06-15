#nullable enable

using System.CommandLine;

namespace SiliconFlow.CLI.Commands;

internal static class AudioApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"audio", @"Audio endpoint commands.");
                         command.Subcommands.Add(AudioCreateAudioTranscriptionsCommandApiCommand.Create());
                         command.Subcommands.Add(AudioCreateSpeechCommandApiCommand.Create());
        return command;
    }
}