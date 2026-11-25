// ArchNet · Runtime Module — service base
// One line of the debug panel. Derive from Service, return your text from Read(), and put
// the component under the module's Service Manager:
//     public class ScoreService : Service { public override string Read() => $"Score: {Game.Score}"; }
// Docs: https://archnet-plateform.fr/#ModuleRuntime

using UnityEngine;

namespace ArchNet.Module
{
    public abstract class Service : MonoBehaviour
    {
        /// <summary>The line shown in the panel; called only while the panel is visible.</summary>
        public abstract string Read();
    }
}
