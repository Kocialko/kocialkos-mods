using MSCLoader;
using UnityEngine;


namespace Full_Satsuma_Remover
{
    public class Full_Satsuma_Remover : Mod
    {
        public override string ID => "Full_Satsuma_Remover"; // Your (unique) mod ID 
        public override string Name => "Full Satsuma Disabler"; // Your mod name
        public override string Author => "MrKocialko"; // Name of the Author (your name)
        public override string Version => "1.0"; // Version
        public override string Description => ""; // Short description of your mod

        public override void ModSetup()
        {
            SetupFunction(Setup.OnMenuLoad, OnMenuLoad);
            SetupFunction(Setup.OnNewGame, OnNewGame);
            SetupFunction(Setup.PreLoad, PreLoad);
            SetupFunction(Setup.OnLoad, OnLoad);
            SetupFunction(Setup.PostLoad, PostLoad);
            SetupFunction(Setup.OnSave, OnSave);
            SetupFunction(Setup.OnGUI, OnGUI);
            SetupFunction(Setup.Update, Update);
            SetupFunction(Setup.FixedUpdate, FixedUpdate);
            SetupFunction(Setup.ModSettings, ModSettings);
        }

        public override void ModSettings()
        {
            // All settings should be created here. 
            // DO NOT put anything that isn't settings or keybinds in here!
        }

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
        public override void PreLoad()
        {
            Object.Destroy(GameObject.Find("CARPARTS)"));
            Object.Destroy(GameObject.Find("Scene/Car"));
            Object.Destroy(GameObject.Find("CAR"));
            Object.Destroy(GameObject.Find("SATSUMA(557kg, 248)"));
            // Called once, right after GAME scene loads but before the game is fully loaded
        }
        public override void OnLoad()
        {
            Object.Destroy(GameObject.Find("CARPARTS)"));
            Object.Destroy(GameObject.Find("Scene/Car"));
            Object.Destroy(GameObject.Find("CAR"));
            Object.Destroy(GameObject.Find("SATSUMA(557kg, 248)"));
            // Called once, when mod is loading after game is fully loaded
        }
        public override void PostLoad()
        {
            Object.Destroy(GameObject.Find("CARPARTS)"));
            Object.Destroy(GameObject.Find("Scene/Car"));
            Object.Destroy(GameObject.Find("CAR"));
            Object.Destroy(GameObject.Find("SATSUMA(557kg, 248)"));
            // Called once, after all mods finished OnLoad
        }
        public override void OnSave()
        {
            Object.Destroy(GameObject.Find("CARPARTS)"));
            Object.Destroy(GameObject.Find("Scene/Car"));
            Object.Destroy(GameObject.Find("CAR"));
            Object.Destroy(GameObject.Find("SATSUMA(557kg, 248)"));
            // Called once, when save and quit
            // Serialize your save file here.
        }
        public override void OnGUI()
        {
            Object.Destroy(GameObject.Find("CARPARTS)"));
            Object.Destroy(GameObject.Find("Scene/Car"));
            Object.Destroy(GameObject.Find("CAR"));
            Object.Destroy(GameObject.Find("SATSUMA(557kg, 248)"));
            // Draw unity OnGUI() here
        }
        public override void Update()
        {
            Object.Destroy(GameObject.Find("CARPARTS)"));
            Object.Destroy(GameObject.Find("Scene/Car"));
            Object.Destroy(GameObject.Find("CAR"));
            Object.Destroy(GameObject.Find("SATSUMA(557kg, 248)"));
            // Update is called once per frame
        }
        public override void FixedUpdate()
        {
            Object.Destroy(GameObject.Find("CARPARTS)"));
            Object.Destroy(GameObject.Find("Scene/Car"));
            Object.Destroy(GameObject.Find("CAR"));
            Object.Destroy(GameObject.Find("SATSUMA(557kg, 248)"));
            // FixedUpdate is called once per fixed frame
        }
    }
}
