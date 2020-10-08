using UnityEngine;

namespace ArchNet.Module.Runtime
{
    /// <summary>
    /// Service showing Version of the project
    /// Author : Louis PAKEL
    /// </summary>
    public class VersionService : Service
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
            // Set service data with Version
            _serviceData = "- Version : [ " + Application.version + "]";
        }
    }
}

