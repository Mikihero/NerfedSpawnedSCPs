using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Enums;
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

        [Description("List of spawnreasons, if an scp is spawned with a spawnreason not in list their hp won't be affected.")]
        public HashSet<SpawnReason> SpawnReasons { get; set; } = new HashSet<SpawnReason>
        {
            SpawnReason.Destroyed,
            SpawnReason.Died,
            SpawnReason.Escaped,
            SpawnReason.None,
            SpawnReason.Respawn,
            SpawnReason.Revived,
            SpawnReason.ForceClass,
            SpawnReason.LateJoin,
            SpawnReason.RoundStart
        };
    }
}