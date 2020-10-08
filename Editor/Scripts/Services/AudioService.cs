using UnityEngine;

namespace ArchNet.Module.Runtime
{
    /// <summary>
    /// Service showing Audio and Volume data
    /// Author : Louis PAKEL
    /// </summary>
    public class AudioService : Service
    {
        [SerializeField, Tooltip("Main Audio Source")]
        private AudioSource _mainAudioSource = null;

        private void Start()
        {
            // Set audio source by default
            if(null == _mainAudioSource)
            {
                _mainAudioSource = gameObject.GetComponent<AudioSource>();
            }
        }

        private void Update()
        {
            if(true == GetServiceActif())
            {
                // service is display
                SetServiceData();
            }
        }


        /// <summary>
        /// Description : Set Service data 
        /// </summary>
        public override void SetServiceData()
        {
            // Init mute and volume
            bool mute = _mainAudioSource.mute;
            float volume = _mainAudioSource.volume * 100;

            // Set service data
            _serviceData = "- Audio : [" + mute + "] | Volume : [" + volume + "]";
        }
    }
}