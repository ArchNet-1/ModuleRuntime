using UnityEngine;

/// <summary>
/// Description : class Service
/// Author : Louis PAKEL
/// </summary>
namespace ArchNet.Module.Runtime
{
    public class Service : MonoBehaviour
    {
        #region Private Properties
        // Service
        private bool _serviceActif = false;



        #endregion

        #region Protected Properties

        // Delta time
        protected float _deltaTime = 0.0f;

        // Service data
        protected string _serviceData = "";

        #endregion

        #region Public Properties

        /// <summary>
        /// Description : Activate the service
        /// </summary>
        public void ActivateService()
        {
            _serviceActif = true;
        }



        /// <summary>
        ///  Description : Get service actif
        /// </summary>
        /// <returns></returns>
        public bool GetServiceActif()
        {
            return _serviceActif;
        }

        /// <summary>
        /// Description : Get service data
        /// </summary>
        /// <returns></returns>
        public string GetServiceData()
        {
            return _serviceData;
        }

        public virtual void SetServiceData() { }



        #endregion
    }
}