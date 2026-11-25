// ArchNet · Runtime Module — audio line: mute state and volume of an AudioSource.
// Docs: https://archnet-plateform.fr/#ModuleRuntime

using UnityEngine;

namespace ArchNet.Module
{
    [AddComponentMenu("ArchNet/Runtime/Audio Service")]
    public class AudioService : Service
    {
        [Tooltip("Empty = the AudioSource on this object.")]
        [SerializeField] AudioSource _mainAudioSource;

        public override string Read()
        {
            if (_mainAudioSource == null && !TryGetComponent(out _mainAudioSource)) return "Audio: no AudioSource";
            return $"Audio: {(_mainAudioSource.mute ? "muted" : "on")} | Volume {_mainAudioSource.volume * 100f:0}%";
        }
    }
}
