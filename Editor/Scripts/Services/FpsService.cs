using UnityEngine;

namespace ArchNet.Module.Runtime
{
    /// <summary>
    /// Service showing FPS and MS data
    /// Author : Louis PAKEL
    /// </summary>
    public class FpsService : Service
    {
        private float _fps = 0.0f;

        private void Update()
        {
            if (true == GetServiceActif())
            {
                _deltaTime += (Time.unscaledDeltaTime - _deltaTime) * 0.1f;

                // service is display
                SetServiceData();
            }
        }
        /// <summary>
        /// Description : Set Service data 
        /// </summary>
        public override void SetServiceData()
        {
            // Init Fps and Msec
            float msec = _deltaTime * 1000.0f;
            _fps = 1f / _deltaTime;

            // Set service data
            _serviceData = "- MS : [" + msec + "]  |  FPS : [" + _fps + "]";
        }

    }
}
