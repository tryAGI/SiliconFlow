#nullable enable

using System.CommandLine;

namespace SiliconFlow.CLI.Commands;

internal static partial class ApiCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");

                         command.Subcommands.Add(AudioApiGroupCommand.Create());
                         command.Subcommands.Add(ChatCompletionsApiGroupCommand.Create());
                         command.Subcommands.Add(DefaultApiGroupCommand.Create());
                         command.Subcommands.Add(EmbeddingsApiGroupCommand.Create());
                         command.Subcommands.Add(ImageApiGroupCommand.Create());
                         command.Subcommands.Add(ModelsApiGroupCommand.Create());
                         command.Subcommands.Add(RerankApiGroupCommand.Create());
                         command.Subcommands.Add(UserInfoApiGroupCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}