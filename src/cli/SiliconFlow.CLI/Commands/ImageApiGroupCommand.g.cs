#nullable enable

using System.CommandLine;

namespace SiliconFlow.CLI.Commands;

internal static class ImageApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"image", @"Image endpoint commands.");
                         command.Subcommands.Add(ImageImageGenerationCommandApiCommand.Create());
        return command;
    }
}