#nullable enable

using System.CommandLine;

namespace SiliconFlow.CLI.Commands;

internal static class ModelsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"models", @"Models endpoint commands.");
                         command.Subcommands.Add(ModelsRetrieveAListOfModelsCommandApiCommand.Create());
        return command;
    }
}