using System.Collections.Generic;
using System.Linq;
using MSCLoader;
using UnityEngine;

namespace FPS_Booster
{
    public class FPS_Booster : Mod
    {
        public override string ID => "FPS_Booster";
        public override string Name => "FPS Booster";
        public override string Author => "MrKocialko, アカツキ2555";
        public override string Version => "1.0";
        public override string Description => "";

        private string[] listOfObjectsToDelete = new string[]
        {
                "TRAIN", "JAIL", "CABIN", "RCO_RUSCKO12(270)", "LakeReflectionFPSCamera", "LakeReflectionRallyTVcam1",
                "THEATRE", "LakeReflectioncam", "LakeSimpleReflectionSceneCamera", "MAP/wheat_silos", "MAP/LakeSmallBottom1",
                "MAP/ChickenHouse", "MAP/PierStore", "BOAT", "MAP/LakeWaterColor", "MAP/HouseOld5", "MAP/BusStop",
                "MAP/LakeSimple", "MAP/Buildings", "MAP/SwampColliders", "MAP/TrafficSigns", "MAP/WaterWell", "MAP/PierHome",
                "MAP/LakeWaterUnder1", "MAP/LakeSound 2", "MAP/LakeSound", "MAP/BirdTower", "MAP/Greenhouse", "MAP/WaterCheck1",
                "MAP/JailSafeTrigger", "MAP/SkijumpHill", "MAP/LakeNice", "MAP/PierRiver", "MAP/Factory", "MAP/LakeWaterUnder2",
                "MISC", "MAP/MESH/FOLIAGE", "MAP/MESH/ROCKS", "MAP/MESH/LogWallLarge", "MAP/MESH/RAILROAD_TUNNEL",
                "MAP/MESH/CHURCHWALL", "MAP/MESH/RAILROAD", "MAP/MESH/WHEAT", "MAP/MESH/LAKEBED", "MAP/MESH/TREES1_COLL",
                "MAP/MESH/TREES2_COLL", "MAP/MESH/TREES3_COLL", "MAP/MESH/ELEC_POLES", "PERAJARVI/HouseBig",
                "PERAJARVI/CHURCH", "PERAJARVI/HouseSmall3", "PERAJARVI/DustCloudLOD1", "PERAJARVI/HouseRinatama3",
                "PERAJARVI/Old3", "PERAJARVI/TerraceHouse", "PERAJARVI/School", "PERAJARVI/HouseWhite", "PERAJARVI/HouseOld1",
                "PERAJARVI/HouseRinatama2", "PERAJARVI/MessageBoard", "COPS", "HUMANS", "Skidmarks", "RYKIPOHJA", "SOCCER",
                "NPC_CARS", "ElectricityBills", "PlayerWanted", "RALLY", "AnimalsMoose", "TRAFFIC"
        };
        private List<SettingsCheckBox> settings = new List<SettingsCheckBox>();

        public override void ModSetup()
        {
            base.ModSetup();

            SetupFunction(Setup.OnLoad, Mod_OnLoad);
        }

        public override void ModSettings()
        {
            base.ModSettings();

            foreach (var item in listOfObjectsToDelete)
            {
                settings.Add(Settings.AddCheckBox(this, item, item, true));
            }
        }

        private void Mod_OnLoad()
        {
            DestroyListedObjects();
        }

        private void DestroyListedObjects()
        {
            GameObject[] allObjects = Resources.FindObjectsOfTypeAll<GameObject>();
            List<GameObject> objectsToDestroy = new List<GameObject>();

            foreach (var setting in settings)
            {
                if (setting.GetValue())
                {
                    var item = setting.Instance.ID;
                    var lastTwoElements = item.Split('/').Reverse().Take(2).Reverse().ToArray();

                    var parent = lastTwoElements.Length == 2 ? lastTwoElements[0] : null;
                    var name = lastTwoElements.Length == 2 ? lastTwoElements[1] : lastTwoElements[0];

                    foreach (GameObject obj in allObjects)
                    {
                        if (obj.name == name && (parent == null || (obj.transform.parent != null && obj.transform.parent.name == parent)))
                        {
                            objectsToDestroy.Add(obj);
                        }
                    }
                }
            }

            foreach (GameObject obj in objectsToDestroy)
            {
                Object.Destroy(obj);
            }
        }
    }
}
