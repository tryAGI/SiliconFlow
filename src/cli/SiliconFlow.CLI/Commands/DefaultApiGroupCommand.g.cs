#nullable enable

using System.CommandLine;

namespace SiliconFlow.CLI.Commands;

internal static partial class DefaultApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"default", @"default endpoint commands.");
                         command.Subcommands.Add(UploadAudioVoiceCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}