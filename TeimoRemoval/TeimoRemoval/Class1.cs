using MSCLoader;

using System;

using UnityEngine;

using Object = UnityEngine.Object;

namespace Teimo_Removal
{
    public class Teimo_Removal : Mod
    {
        public override string ID => "Teimo_Removal"; // Your (unique) mod ID 
        public override string Name => "Teimo Removal"; // Your mod name
        public override string Author => "MrKocialko"; // Name of the Author (your name)
        public override string Version => "1.0"; // Version
        public override string Description => ""; // Short description of your mod

        public override void ModSetup()
        {
            SetupFunction(Setup.PostLoad, PostLoad);
            SetupFunction(Setup.Update, Update);
        }

        public override void PostLoad()
        {
            Object.Destroy(GameObject.Find("STORE/TeimoInBike"));
            Object.Destroy(GameObject.Find("STORE/TeimoInShop"));
        }
        public override void Update()
        {
            Object.Destroy(GameObject.Find("STORE/TeimoInBike"));
            Object.Destroy(GameObject.Find("STORE/TeimoInShop"));
        }
    }
}
