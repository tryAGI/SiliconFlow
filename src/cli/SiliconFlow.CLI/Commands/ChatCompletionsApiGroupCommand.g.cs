#nullable enable

using System.CommandLine;

namespace SiliconFlow.CLI.Commands;

internal static class ChatCompletionsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"chat-completions", @"Chat Completions endpoint commands.");
                         command.Subcommands.Add(ChatCompletionsChatCompletionsCommandApiCommand.Create());
                         command.Subcommands.Add(ChatCompletionsChatCompletionsAsStreamCommandApiCommand.Create());
        return command;
    }
}