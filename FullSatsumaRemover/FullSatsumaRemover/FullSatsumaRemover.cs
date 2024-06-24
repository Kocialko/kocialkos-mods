using MSCLoader;

using System;

using UnityEngine;
using Object = UnityEngine.Object;


namespace Full_Satsuma_Remover
{
    public class Full_Satsuma_Remover : Mod
    {
        public override string ID => "Full_Satsuma_Remover"; // Your (unique) mod ID 
        public override string Name => "Full Satsuma Disabler"; // Your mod name
        public override string Author => "MrKocialko"; // Name of the Author (your name)
        public override string Version => "1.0"; // Version
        public override string Description => ""; // Short description of your mod

        public override void OnMenuLoad()
        {
            Object.Destroy(GameObject.Find("CARPARTS)"));
            Object.Destroy(GameObject.Find("Scene/Car"));
            Object.Destroy(GameObject.Find("CAR"));
            Object.Destroy(GameObject.Find("SATSUMA(557kg, 248)"));
            // Called once, when the mod is loaded in the main menu
        }
        public override void OnNewGame()
        {
            Object.Destroy(GameObject.Find("CARPARTS)"));
            Object.Destroy(GameObject.Find("Scene/Car"));
            Object.Destroy(GameObject.Find("CAR"));
            Object.Destroy(GameObject.Find("SATSUMA(557kg, 248)"));
            // Called once, when creating a new game. This is useful for deleting old mod saves
        }
        public override void OnLoad()
        {
            Object.Destroy(GameObject.Find("CARPARTS)"));
            Object.Destroy(GameObject.Find("Scene/Car"));
            Object.Destroy(GameObject.Find("CAR"));
            Object.Destroy(GameObject.Find("SATSUMA(557kg, 248)"));
            // Called once, when mod is loading after game is fully loaded
        }
    }
}
