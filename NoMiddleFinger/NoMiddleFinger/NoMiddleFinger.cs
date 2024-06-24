using MSCLoader;
using UnityEngine;
using System;

namespace No_Middle_Finger
{
    public class No_Middle_Finger : Mod
    {
        public override string ID => "No_Middle_Finger"; //Your mod ID (unique)
        public override string Name => "No Middle Finger"; //You mod name
        public override string Author => "Kocialko"; //Your Username
        public override string Version => "1.1"; //Version
        public override string Description => "Crashes your game if you press M key"; //Short description of your mod

        public override void ModSetup()
        {
            SetupFunction(Setup.Update, Mod_Update);
        }

        private void Mod_Update()
        {
            if (Input.GetKeyDown(KeyCode.M))
            {
                Application.Quit();
            }
            // Update is called once per frame
        }
    }
}
