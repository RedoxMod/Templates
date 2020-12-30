using System.Threading.Tasks;

using Redox.Core.Plugins.CSharp;
using Redox.Unturned.Events.Player;
using Redox.Unturned.Player;
using Redox.Unturned.Plugins;

namespace ExamplePlugin
{
    //Holds information about the plugin. Required attribute!!
    [PluginInfo("ExamplePlugin", "Testing plugin", "ice cold", "1.0.0")]
    public sealed class UnturnedExamplePlugin : UnturnedPlugin
    {
        //Let's hold the instance here so we can access it througout our application.
        internal static ExampleConfig Config;

        //Gets called when your plugin is getting loaded.
        protected override async Task OnEnableAsync()
        {
            Config = await GetConfigAsync<ExampleConfig>("options");
            UnturnedPlayerEvents.OnPlayerConnected += OnPlayerConnected;
        }
        private void OnPlayerConnected(UnturnedPlayer player)
        {
            Server.BroadcastChat($"{player.DisplayName} has joined the server.");
        }

        //Gets called when your plugin is getting unloaded.
        protected override Task OnDisableAsync()
        {
            UnturnedPlayerEvents.OnPlayerConnected -= OnPlayerConnected;
            return Task.CompletedTask;
        }
    }
}
