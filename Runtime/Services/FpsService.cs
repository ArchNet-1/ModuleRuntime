// ArchNet · Runtime Module — frame rate line: frames per second and frame time, smoothed.
// Docs: https://archnet-plateform.fr/#ModuleRuntime

using UnityEngine;

namespace ArchNet.Module
{
    [AddComponentMenu("ArchNet/Runtime/FPS Service")]
    public class FpsService : Service
    {
        float _smoothedDelta = 1f / 60f;

        void Update() => _smoothedDelta += (Time.unscaledDeltaTime - _smoothedDelta) * 0.1f;

        public override string Read() => $"FPS: {1f / _smoothedDelta:0} | {_smoothedDelta * 1000f:0.0} ms";
    }
}
