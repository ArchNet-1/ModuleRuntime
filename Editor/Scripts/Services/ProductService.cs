using UnityEngine;

namespace ArchNet.Module.Runtime
{
    /// <summary>
    /// Service showing Product and company data
    /// Author : Louis PAKEL
    /// </summary>
    public class ProductService : Service
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
            // Set service data with product name and company name
            _serviceData = "- Product : [" + Application.productName + "] | Company : [" + Application.companyName + "]";
        }
    }
}