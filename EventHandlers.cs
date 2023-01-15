﻿using System;
using Exiled.API.Enums;
using Exiled.API.Extensions;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using MEC;
using PlayerRoles;

namespace NerfedSpawnedSCPs
{
    public class EventHandlers
    {
        public void OnChangingRole(ChangingRoleEventArgs ev)
        {
            if (ev.Reason != SpawnReason.ForceClass || ev.NewRole == RoleTypeId.Scp079)
                return;
            if (ev.NewRole.GetSide() == Side.Scp && Round.ElapsedTime > TimeSpan.FromMinutes(Plugin.Instance.Config.TimeToActivate))
            {
                Timing.CallDelayed(0.1f, () => ev.Player.Health *= (Plugin.Instance.Config.SCPHealthPercent/100));
                Log.Debug($"Player {ev.Player.Nickname}({ev.Player.RawUserId}) playing as {ev.NewRole.GetFullName()} had their hp lowered to {Plugin.Instance.Config.SCPHealthPercent}%");
            }
        }
    }
}