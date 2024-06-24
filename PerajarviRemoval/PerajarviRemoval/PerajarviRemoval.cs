using MSCLoader;

using System;

using UnityEngine;

using Object = UnityEngine.Object;

namespace Perajarvi_Removal
{
    public class Perajarvi_Removal : Mod
    {
        public override string ID => "Perajarvi_Removal"; // Your (unique) mod ID 
        public override string Name => "Perajarvi Removal"; // Your mod name
        public override string Author => "MrKocialko"; // Name of the Author (your name)
        public override string Version => "1.0"; // Version
        public override string Description => ""; // Short description of your mod

        public override void ModSetup()
        {
            SetupFunction(Setup.PostLoad, Mod_PostLoad);
        }

        private void Mod_PostLoad()
        {
            Object.Destroy(GameObject.Find("WATERFACILITY"));
            Object.Destroy(GameObject.Find("STORE"));
            Object.Destroy(GameObject.Find("PERAJARVI"));
            Object.Destroy(GameObject.Find("INSPECTION"));
            Object.Destroy(GameObject.Find("THEATRE"));
        }
    }
}
