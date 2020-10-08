using UnityEngine;

namespace ArchNet.Module.Runtime
{
    /// <summary>
    /// Service showing shadow resolution and shadow level data
    /// Author : Louis PAKEL
    /// </summary>
    public class ShadowService : Service
    {
        private void Update()
        {
            if (true == GetServiceActif())
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
            // Init shadow resolution and shadow Level
            string shadowresolution = QualitySettings.shadows.ToString();
            string shadowLevel = QualitySettings.shadowResolution.ToString();

            // Set service data
            _serviceData = "- Shadow Resolution : [" + shadowresolution + "] | Shadow Level : [" + shadowLevel + "]";
        }
    }
}