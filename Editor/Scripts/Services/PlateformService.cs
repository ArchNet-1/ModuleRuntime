using UnityEngine;

namespace ArchNet.Module.Runtime
{
    /// <summary>
    /// Service showing Plateform type data
    /// Author : Louis PAKEL
    /// </summary>
    public class PlateformService : Service
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
            // Set service data with plateform type
            _serviceData = "- Plateform : [ " + Application.platform + "]";
        }
    }
}