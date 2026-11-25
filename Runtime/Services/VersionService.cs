// ArchNet · Runtime Module — version line: game version and Unity version.
// Docs: https://archnet-plateform.fr/#ModuleRuntime

using UnityEngine;

namespace ArchNet.Module
{
    [AddComponentMenu("ArchNet/Runtime/Version Service")]
    public class VersionService : Service
    {
        public override string Read() => $"Version: {Application.version} | Unity {Application.unityVersion}";
    }
}
