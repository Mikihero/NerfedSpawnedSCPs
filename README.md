<a href="https://github.com/Mikihero/NerfedSpawnedSCPs/releases"><img src="https://img.shields.io/github/downloads/Mikihero/NerfedSpawnedSCPs/total?label=Downloads" alt="Downloads"></a>
# NerfedSpawnedSCPs
An SCP:SL EXILED plugin that makes anyone forceclassed to an scp after a configurable amount of time has passed, to have their hp lowered to a configurable amount.
# Permissions
- nss.immunity - anyone with this permission will be immune.
# Default Config
```yaml
nerfed_spawned_s_c_ps:
  # Whether or not the plugin should be enabled.
  is_enabled: true
  # Whether or not debug logs should be shown.
  debug: false
  # Amount of time in minutes after which new SCP's will have their hp lowered. Default: 3
  time_to_activate: 3
  # The amount of hp in percentages an SCP should be left with if they are spawned in late. Default: 50
  s_c_p_health_percent: 50
  # List of spawnreasons, if an scp is spawned with a spawnreason not in list their hp won't be affected.
  spawn_reasons:
  - Destroyed
  - Died
  - Escaped
  - None
  - Respawn
  - Revived
  - ForceClass
  - LateJoin
  - RoundStart
```
