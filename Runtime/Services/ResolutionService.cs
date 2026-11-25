// ArchNet · Runtime Module — screen line: window size, window mode and refresh rate.
// Docs: https://archnet-plateform.fr/#ModuleRuntime

using UnityEngine;

namespace ArchNet.Module
{
    [AddComponentMenu("ArchNet/Runtime/Resolution Service")]
    public class ResolutionService : Service
    {
        public override string Read() =>
            $"Screen: {Screen.width} x {Screen.height} | {Screen.fullScreenMode} | {Screen.currentResolution.refreshRateRatio.value:0} Hz";
    }
}
