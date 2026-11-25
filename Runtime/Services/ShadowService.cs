// ArchNet · Runtime Module — shadow line: shadow type and resolution from QualitySettings.
// Docs: https://archnet-plateform.fr/#ModuleRuntime

using UnityEngine;

namespace ArchNet.Module
{
    [AddComponentMenu("ArchNet/Runtime/Shadow Service")]
    public class ShadowService : Service
    {
        public override string Read() => $"Shadows: {QualitySettings.shadows} | {QualitySettings.shadowResolution}";
    }
}
