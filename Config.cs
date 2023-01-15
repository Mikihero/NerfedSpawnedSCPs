using System.ComponentModel;
using Exiled.API.Interfaces;

namespace NerfedSpawnedSCPs
{
    public class Config : IConfig
    {
        [Description("Whether or not the plugin should be enabled.")]
        public bool IsEnabled { get; set; } = true;
        
        [Description("Whether or not debug logs should be shown.")]
        public bool Debug { get; set; } = false;

        [Description("Amount of time in minutes after which new SCP's will have their hp lowered. Default: 3")]
        public float TimeToActivate { get; set; } = 3;
        
        [Description("The amount of hp in percentages an SCP should be left with if they are spawned in late. Default: 50")]
        public float SCPHealthPercent { get; set; } = 50;
    }
}