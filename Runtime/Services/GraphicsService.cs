// ArchNet · Runtime Module — graphics line: quality level name and anti-aliasing.
// Docs: https://archnet-plateform.fr/#ModuleRuntime

using UnityEngine;

namespace ArchNet.Module
{
    [AddComponentMenu("ArchNet/Runtime/Graphics Service")]
    public class GraphicsService : Service
    {
        public override string Read()
        {
            string quality = QualitySettings.names[QualitySettings.GetQualityLevel()];
            string antiAliasing = QualitySettings.antiAliasing > 0 ? $"{QualitySettings.antiAliasing}x" : "off";
            return $"Quality: {quality} | Anti-aliasing: {antiAliasing} | GPU: {SystemInfo.graphicsDeviceName}";
        }
    }
}
