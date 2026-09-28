#nullable enable

using System.CommandLine;

namespace SiliconFlow.CLI.Commands;

internal static partial class RerankApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"rerank", @"Rerank endpoint commands.");
                         command.Subcommands.Add(RerankCreateRerankCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}