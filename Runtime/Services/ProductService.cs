// ArchNet · Runtime Module — product line: game and company names from Player Settings.
// Docs: https://archnet-plateform.fr/#ModuleRuntime

using UnityEngine;

namespace ArchNet.Module
{
    [AddComponentMenu("ArchNet/Runtime/Product Service")]
    public class ProductService : Service
    {
        public override string Read() => $"Product: {Application.productName} | {Application.companyName}";
    }
}
