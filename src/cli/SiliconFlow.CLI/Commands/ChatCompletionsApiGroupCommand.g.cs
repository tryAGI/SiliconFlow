#nullable enable

using System.CommandLine;

namespace SiliconFlow.CLI.Commands;

internal static partial class ChatCompletionsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"chat-completions", @"Chat Completions endpoint commands.");
                         command.Subcommands.Add(ChatCompletionsChatCompletionsCommandApiCommand.Create());
                         command.Subcommands.Add(ChatCompletionsChatCompletionsAsStreamCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}