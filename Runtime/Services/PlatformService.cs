// ArchNet · Runtime Module — platform line: runtime platform and operating system.
// Docs: https://archnet-plateform.fr/#ModuleRuntime

using UnityEngine;

namespace ArchNet.Module
{
    [AddComponentMenu("ArchNet/Runtime/Platform Service")]
    public class PlatformService : Service
    {
        public override string Read() => $"Platform: {Application.platform} | {SystemInfo.operatingSystem}";
    }
}
