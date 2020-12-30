using System;

using Redox.API.Commands;
using Redox.API.Player;
using Redox.Core.Commands;
using Redox.Unturned.Player;

namespace ExamplePlugin.Commands
{
    [CommandInfo("rules", CommandCaller.Player)]
    [CommandHelp("Shows the server rules.", "/rules")]
    public class RulesCommand : Command
    {
        protected override bool Execute(CommandExecutor executor, string[] args)
        {
            UnturnedPlayer player = (UnturnedPlayer)executor.GetPlayer();

            foreach(string rule in UnturnedExamplePlugin.Config.Rules)
            {
                player.SendMessage(UnturnedExamplePlugin.Config.ChatName, rule);
            }
            return true; //return true if the execution was successfull, otherwise return false and it will show the help text to the player.
        }
    }
}
