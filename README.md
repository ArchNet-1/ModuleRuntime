<p align="center">
  <a href="https://archnet-plateform.fr"><img src="https://archnet-plateform.fr/ArchNetLogoWithBck.png" alt="ArchNet" width="240"></a>
</p>

# ArchNet · Runtime Module

A debug panel for builds: press F1 to show live data (FPS, audio, graphics, screen, platform, version…).

- Unity **6000.0** or newer · Needs `com.unity.ugui`.
- Part of [ArchNet](https://archnet-plateform.fr), free and open-source Unity packages

## Install

*Window > Package Manager > + > Install package from git URL…*

```
https://github.com/ArchNet-1/ModuleRuntime.git
```

## Use

Drop the **ModuleRuntime** prefab into a canvas and press F1. Add your own line:

```csharp
using ArchNet.Module;

public class ScoreService : Service { public override string Read() => $"Score: {Game.Score}"; }
```

## License

See [LICENSE.md](LICENSE.md).
