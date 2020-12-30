using Redox.API.Configuration;
using Redox.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePlugin
{
    [ConfigInfo("options", ConfigExtension.Json)]
    public class ExampleConfig : PluginConfiguration
    {
        public string ChatName;

        public string[] Rules;

        //Gets called when the configuration is getting created. Use this to define the initial values to your fields.
        protected override void LoadDefaults()
        {
            ChatName = "Rules";
            Rules = new string[]
            {
                "The first rule of Fight Club is: You do not talk about Fight Club.",
                "The second rule of Fight Club is: You do not talk about Fight Club.",
                "Third rule of Fight Club: Someone yells STOP, goes limp, taps out, the fight is over."
            };
        }
    }
}
