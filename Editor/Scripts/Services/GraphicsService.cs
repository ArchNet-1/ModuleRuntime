using UnityEngine;

namespace ArchNet.Module.Runtime
{   
	/// <summary>
     /// Service showing Quality and Anti aliasing data
     /// Author : Louis PAKEL
     /// </summary>
    public class GraphicsService : Service
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
			// Init quality and antialiasing
			string quality = "Unknow";
			string antialiasing = "Unknow";

			//SET QUALITY LEVEL
			switch (QualitySettings.GetQualityLevel())
			{
				case 0:
					quality = "Very Low";
					break;
				case 1:
					quality = "Low";
					break;
				case 2:
					quality = "Medium";
					break;
				case 3:
					quality = "High";
					break;
				case 4:
					quality = "Very High";
					break;
				case 5:
					quality = "Ultra";
					break;
			}

			// SET ANTI ALIASING
			switch (QualitySettings.antiAliasing.ToString())
			{
				case "2":
					antialiasing = "AA x2";
					break;
				case "4":
					antialiasing = "AA x4";
					break;
				case "8":
					antialiasing = "AA x8";
					break;
			}

			// Set service data
			_serviceData = "- Graphic Quality : [" + quality + "] | Anti Aliasing : |" + antialiasing + "]";
		}
	}
}