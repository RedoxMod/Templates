﻿using System;

using Redox.API.Commands;
using Redox.API.Player;
using Redox.Core.Commands;

namespace UniversalExamplePlugin.Commands
{
    [CommandInfo("rules", CommandCaller.Player)]
    [CommandHelp("Shows the server rules.", "/rules")]
    public class RulesCommand : Command
    {
        protected override bool Execute(CommandExecutor executor, string[] args)
        {
            IRedoxPlayer player = executor.GetPlayer();

            foreach(string rule in UniversalExamplePlugin.Config.Rules)
            {
                player.SendMessage(UniversalExamplePlugin.Config.ChatName, rule);
            }
            return true; //return true if the execution was successfull, otherwise return false and it will show the help text to the player.
        }
    }
}
