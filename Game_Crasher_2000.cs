using MSCLoader;
using System;

namespace Game_Crasher_2000
{
    public class Game_Crasher_2000 : Mod
    {
        public override string ID => "Game_Crasher_2000";
        public override string Name => "Game Crasher 2000";
        public override string Author => "MrKocialko";
        public override string Version => "1.0";
        public override string Description => "No My Summer Car for you!";

        public override void ModSetup()
        {
            SetupFunction(Setup.OnMenuLoad, Mod_OnMenuLoad);
        }

        private void Mod_OnMenuLoad()
        {
            Environment.Exit(1);
        }
    }
}
