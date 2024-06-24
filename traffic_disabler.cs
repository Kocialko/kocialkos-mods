using MSCLoader;
using UnityEngine;

namespace traffic_disabler
{
    public class Traffic_disabler : Mod
    {
        public override string ID => "traffic_disabler";
        public override string Name => "Traffic Disabler";
        public override string Author => "Kocialko";
        public override string Version => "1.5";
        public override string Description => "disables traffic";

        public override void ModSetup()
        {
            SetupFunction(Setup.OnLoad, OnLoad);
            SetupFunction(Setup.Update, Update);
        }

        public override void ModSettings()
        {
        }

        public override void OnLoad()
        {
            Object.Destroy(GameObject.Find("TRAFFIC"));
            Object.Destroy(GameObject.Find("NPC_CARS"));
            Object.Destroy(GameObject.Find("RALLY/RallyCars"));
            Object.Destroy(GameObject.Find("HUMANS/Randomizer"));
            Object.Destroy(GameObject.Find("TRAIN"));
            Object.Destroy(GameObject.Find("COPS"));
        }
        public override void Update()
        {
            Object.Destroy(GameObject.Find("TRAFFIC"));
            Object.Destroy(GameObject.Find("NPC_CARS"));
            Object.Destroy(GameObject.Find("RALLY/RallyCars"));
            Object.Destroy(GameObject.Find("HUMANS/Randomizer"));
            Object.Destroy(GameObject.Find("TRAIN"));
            Object.Destroy(GameObject.Find("COPS"));
        }
    }
}
