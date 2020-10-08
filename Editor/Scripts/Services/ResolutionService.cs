using UnityEngine;

namespace ArchNet.Module.Runtime
{
    /// <summary>
    /// Service showing Resolution and screen mode data
    /// Author : Louis PAKEL
    /// </summary>
    public class ResolutionService : Service
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
            // Init resolution and Screen mode
            UnityEngine.Resolution resolution = Screen.currentResolution;
            FullScreenMode screenMode = Screen.fullScreenMode;

            // Set service data
            _serviceData = "- Current Resolution : [" + resolution.height +  " : " + resolution.width + "] | FullScreen : [" + screenMode + "]";
        }
    }
}