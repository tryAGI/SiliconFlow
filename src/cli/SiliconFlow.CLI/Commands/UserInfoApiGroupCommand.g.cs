#nullable enable

using System.CommandLine;

namespace SiliconFlow.CLI.Commands;

internal static partial class UserInfoApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"user-info", @"UserInfo endpoint commands.");
                         command.Subcommands.Add(UserInfoUserInfoCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}