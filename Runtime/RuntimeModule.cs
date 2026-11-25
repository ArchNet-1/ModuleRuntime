// ArchNet · Runtime Module
// A debug panel for builds: press F1 to show live data (FPS, audio, graphics, screen,
// platform, version…). Each line comes from a Service component under the module.
// Drop the ModuleRuntime prefab (Runtime/Resources/Prefabs) into a canvas.
// Docs: https://archnet-plateform.fr/#ModuleRuntime

using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;
#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif

namespace ArchNet.Module
{
    [AddComponentMenu("ArchNet/Runtime Module")]
    public class RuntimeModule : MonoBehaviour
    {
        [Tooltip("Parent of the Service components. Empty = first child.")]
        [SerializeField] Transform _serviceManager;
        [Tooltip("Services to show. Services found under the Service Manager are added at start.")]
        [SerializeField] List<Service> _services = new List<Service>();
        [Tooltip("Text that shows the data. Empty = the TMP text on the second child.")]
        [SerializeField] TMP_Text _runtimeServiceText;
        [SerializeField] bool _visibleAtStart;
        [Tooltip("Refreshes per second while the panel is visible.")]
        [Min(1)]
        [SerializeField] float _refreshRate = 4f;

        readonly StringBuilder _text = new StringBuilder();
        bool _visible;
        float _nextRefresh;

        public bool Visible
        {
            get => _visible;
            set
            {
                _visible = value;
                if (_runtimeServiceText != null) _runtimeServiceText.enabled = value;
                _nextRefresh = 0f;
            }
        }

        void Start()
        {
            if (_serviceManager == null && transform.childCount > 0) _serviceManager = transform.GetChild(0);
            if (_runtimeServiceText == null && transform.childCount > 1) _runtimeServiceText = transform.GetChild(1).GetComponent<TMP_Text>();
            if (_serviceManager != null)
            {
                foreach (Service service in _serviceManager.GetComponentsInChildren<Service>(true))
                {
                    if (!_services.Contains(service)) _services.Add(service);
                }
            }
            if (_runtimeServiceText == null) Debug.LogError("[ArchNet] Runtime Module: no TMP text to show the data.", this);
            Visible = _visibleAtStart;
        }

        void Update()
        {
            if (TogglePressed()) Visible = !Visible;
            if (!_visible || _runtimeServiceText == null || Time.unscaledTime < _nextRefresh) return;

            _nextRefresh = Time.unscaledTime + 1f / _refreshRate;
            _text.Clear();
            foreach (Service service in _services)
            {
                if (service != null && service.isActiveAndEnabled) _text.AppendLine(service.Read());
            }
            _runtimeServiceText.text = _text.ToString();
        }

        static bool TogglePressed()
        {
#if ENABLE_INPUT_SYSTEM
            if (Keyboard.current != null && Keyboard.current.f1Key.wasPressedThisFrame) return true;
#endif
#if ENABLE_LEGACY_INPUT_MANAGER
            if (Input.GetKeyDown(KeyCode.F1)) return true;
#endif
            return false;
        }
    }
}
