#nullable enable

using System.CommandLine;

namespace SiliconFlow.CLI.Commands;

internal static partial class ImageApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"image", @"Image endpoint commands.");
                         command.Subcommands.Add(ImageImageGenerationCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}