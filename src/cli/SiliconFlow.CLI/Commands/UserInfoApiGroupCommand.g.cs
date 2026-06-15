#nullable enable

using System.CommandLine;

namespace SiliconFlow.CLI.Commands;

internal static class UserInfoApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"user-info", @"UserInfo endpoint commands.");
                         command.Subcommands.Add(UserInfoUserInfoCommandApiCommand.Create());
        return command;
    }
}