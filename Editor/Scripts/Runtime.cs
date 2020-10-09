using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;


namespace ArchNet.Module.Runtime
{
    public class Runtime : MonoBehaviour
    {
        // Service Manager
        [SerializeField, Tooltip("Service Manager")]
        private Transform _serviceManager = null;

        [Header("All Runtime Services")]

        // Array of Services
        [SerializeField, Tooltip("Services")]
        private List<Service> _services = new List<Service>();

        [SerializeField, Tooltip("PlayerPref Module Actif")]
        private bool _playerPrefModuleActif = false;

        [SerializeField, Tooltip("Runtime Service Text")]
        private TMP_Text _runtimeServiceText = null;

        // is player pref module is actif
        private bool _isPlayerPrefActif = false;


        // Display Service data
        private bool _displayService = false;

        public void Start()
        {
            // Set player pref module properties
            SetPlayerPrefActif(_playerPrefModuleActif);

            // Force runtime Service value
            if(null == _runtimeServiceText)
            {
                _runtimeServiceText = gameObject.transform.GetChild(1).GetComponent<TMP_Text>();
            }

            // Check if the module is available
            ModuleAvailable();

            // Init services
            InitServices();
        }

        /// <summary>
        /// Description : Check if the module is available
        /// </summary>
        private void ModuleAvailable()
        {
            if (null == _runtimeServiceText)
            {
                Debug.LogError(Constants.ERROR_411);
            }

            if(null == _services)
            {
                Debug.LogError(Constants.ERROR_410);
            }
        }

        /// <summary>
        /// Description : Init all services
        /// </summary>
        private void InitServices()
        {
            // Service Manager misssing
            if(null == _serviceManager)
            {
                // Set service manager
                _serviceManager = gameObject.transform.GetChild(0);
            }

            // Runtime text misssing
            if (null == _runtimeServiceText)
            {
                // Set service manager
                _runtimeServiceText = gameObject.transform.GetChild(1).GetComponent<TMP_Text>();
            }

            // services list is empty
            if (0 == _services.Count)
            {
                foreach(Transform lChild in _serviceManager)
                {
                    // Add child service into list
                    _services.Add(lChild.gameObject.GetComponent<Service>());
                }
            }

            // Check every service
            foreach (Service lService in _services)
            {
                // Init specific service
                ServiceAvailable(lService);
            }

            // Generate Runtime Service Text
            GenerateRuntimeServiceText();
        }

        /// <summary>
        /// Description : Check if the service is available
        /// </summary>
        /// <param name="pService">Service</param>
        private void ServiceAvailable(Service pService)
        {
            // Service exist
            if(null != pService)
            {
                // activate service
                pService.ActivateService();
            }
        }

        public void Update()
        {
            // Module Player Pref exist
            if(true == isPlayerPrefActif())
            {
                //if (Input.GetKeyDown(PlayerPrefSettings.Instance().key_runtime))
                //{
                //    // Reset text
                //    _runtimeServiceText.text = "";

                //    // Display Services
                //    SetDisplayService(!GetDisplayService());
                //}
            }
            // Default
            else
            {
                if(Input.GetKeyDown(KeyCode.F1))
                {
                    // Reset text
                    _runtimeServiceText.text = "";

                    // Display Services
                    SetDisplayService(!GetDisplayService());
                }
            }

            if(true == GetDisplayService())
            {
                // Generate Runtime Service Text
                GenerateRuntimeServiceText();
            }
        }


        /// <summary>
        /// Description : Generate all services data into runtime service text value
        /// </summary>
        private void GenerateRuntimeServiceText()
        {
            // Reset text
            _runtimeServiceText.text = "";

            foreach (Service lService in _services)
            {
                // Init specific service
                _runtimeServiceText.text += lService.GetServiceData() + "\n";
            }
        }

        /// <summary>
        /// Description : Check if service has player pref module actif
        /// </summary>
        /// <returns></returns>
        public bool isPlayerPrefActif()
        {
            return _isPlayerPrefActif;
        }

        /// <summary>
        ///  Description : Ser player pref actif
        /// </summary>
        /// <returns></returns>
        public void SetPlayerPrefActif(bool pValue)
        {
            _isPlayerPrefActif = pValue;
        }

        /// <summary>
        /// Description : Set bool display service data
        /// </summary>
        /// <param name="pValue"></param>
        public void SetDisplayService(bool pValue)
        {
            _displayService = pValue;
        }

        /// <summary>
        /// Description : Return if the service data is display or not
        /// </summary>
        /// <returns></returns>
        public bool GetDisplayService()
        {
            return _displayService;
        }
    }
}