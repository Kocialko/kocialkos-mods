using MSCLoader;

using System;

using UnityEngine;

using Object = UnityEngine.Object;

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
        }

        public override void OnLoad()
        {
            Object.Destroy(GameObject.Find("TRAFFIC"));
            Object.Destroy(GameObject.Find("NPC_CARS"));
            Object.Destroy(GameObject.Find("RALLY").transform.Find("RallyCars").gameObject);
            Object.Destroy(GameObject.Find("HUMANS").transform.Find("Randomizer").gameObject);
            Object.Destroy(GameObject.Find("TRAIN"));
            Object.Destroy(GameObject.Find("COPS"));
        }
    }
}
