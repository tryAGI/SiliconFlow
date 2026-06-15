#nullable enable

using System.CommandLine;

namespace SiliconFlow.CLI.Commands;

internal static class DefaultApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"default", @"default endpoint commands.");
                         command.Subcommands.Add(UploadAudioVoiceCommandApiCommand.Create());
        return command;
    }
}