using System;
using System.Threading.Tasks;
using Redox.API.Player;
using Redox.Core.Events.Player;
using Redox.Core.Plugins.CSharp;

namespace UniversalExamplePlugin
{
    //Holds information about the plugin. Required attribute!!
    [PluginInfo("UniversalExamplePlugin", "Universal example plugin", "ice cold", "1.0.0.0")]
    public class UniversalExamplePlugin : UniversalPlugin
    {
        //Let's hold the instance here so we can access it througout our application.
        internal static ExampleConfig Config;

        //Gets called when your plugin is getting loaded.
        protected override async Task OnEnableAsync()
        {
            //Resolves the instance to the configuration.
            Config = await GetConfigAsync<ExampleConfig>("options");
            PlayerEvents.U_OnPlayerConnected += OnPlayerConnected;
        }

        private void OnPlayerConnected(IRedoxPlayer player)
        {
            Server.BroadcastChat($"{player.DisplayName} has joined the server.");
        }

        //Gets called when your plugin is getting unloaded.
        protected override Task OnDisableAsync()
        {
            PlayerEvents.U_OnPlayerConnected -= OnPlayerConnected;
            return Task.CompletedTask;
        }
    }
}
