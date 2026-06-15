#nullable enable

using System.CommandLine;

namespace SiliconFlow.CLI.Commands;

internal static class RerankApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"rerank", @"Rerank endpoint commands.");
                         command.Subcommands.Add(RerankCreateRerankCommandApiCommand.Create());
        return command;
    }
}