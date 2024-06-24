using MSCLoader;
using UnityEngine;

namespace FPS_Booster
{
    public class FPS_Booster : Mod
    {
        public override string ID => "FPS_Booster";
        public override string Name => "FPS Booster";
        public override string Author => "MrKocialko";
        public override string Version => "1.0";
        public override string Description => "";

        public override void ModSetup()
        {
            SetupFunction(Setup.Update, Mod_Update);
            SetupFunction(Setup.OnLoad, Mod_OnLoad);
        }

        private void Mod_OnLoad()
        {
            Object.Destroy(GameObject.Find("TRAIN"));
            Object.Destroy(GameObject.Find("JAIL"));
            Object.Destroy(GameObject.Find("CABIN"));
            Object.Destroy(GameObject.Find("RCO_RUSCKO12(270)"));
            Object.Destroy(GameObject.Find("LakeReflectionFPSCamera"));
            Object.Destroy(GameObject.Find("LakeReflectionRallyTVcam1"));
            Object.Destroy(GameObject.Find("THEATRE"));
            Object.Destroy(GameObject.Find("LakeReflectioncam"));
            Object.Destroy(GameObject.Find("LakeSimpleReflectionSceneCamera"));
            Object.Destroy(GameObject.Find("MAP/wheat_silos"));
            Object.Destroy(GameObject.Find("MAP/LakeSmallBottom1"));
            Object.Destroy(GameObject.Find("MAP/ChickenHouse"));
            Object.Destroy(GameObject.Find("MAP/PierStore"));
            Object.Destroy(GameObject.Find("BOAT"));
            Object.Destroy(GameObject.Find("MAP/LakeWaterColor"));
            Object.Destroy(GameObject.Find("MAP/HouseOld5"));
            Object.Destroy(GameObject.Find("MAP/BusStop"));
            Object.Destroy(GameObject.Find("MAP/LakeSimple"));
            Object.Destroy(GameObject.Find("MAP/Buildings"));
            Object.Destroy(GameObject.Find("MAP/SwampColliders"));
            Object.Destroy(GameObject.Find("MAP/TrafficSigns"));
            Object.Destroy(GameObject.Find("MAP/WaterWell"));
            Object.Destroy(GameObject.Find("MAP/PierHome"));
            Object.Destroy(GameObject.Find("MAP/LakeWaterUnder1"));
            Object.Destroy(GameObject.Find("MAP/LakeSound 2"));
            Object.Destroy(GameObject.Find("MAP/LakeSound"));
            Object.Destroy(GameObject.Find("MAP/BirdTower"));
            Object.Destroy(GameObject.Find("MAP/Greenhouse"));
            Object.Destroy(GameObject.Find("MAP/WaterCheck1"));
            Object.Destroy(GameObject.Find("MAP/JailSafeTrigger"));
            Object.Destroy(GameObject.Find("MAP/SkijumpHill"));
            Object.Destroy(GameObject.Find("MAP/LakeNice"));
            Object.Destroy(GameObject.Find("MAP/PierRiver"));
            Object.Destroy(GameObject.Find("MAP/Factory"));
            Object.Destroy(GameObject.Find("MAP/LakeWaterUnder2"));
            Object.Destroy(GameObject.Find("MISC"));
            Object.Destroy(GameObject.Find("MAP/MESH/FOLIAGE"));
            Object.Destroy(GameObject.Find("MAP/MESH/ROCKS"));
            Object.Destroy(GameObject.Find("MAP/MESH/LogWallLarge"));
            Object.Destroy(GameObject.Find("MAP/MESH/RAILROAD_TUNNEL"));
            Object.Destroy(GameObject.Find("MAP/MESH/CHURCHWALL"));
            Object.Destroy(GameObject.Find("MAP/MESH/RAILROAD"));
            Object.Destroy(GameObject.Find("MAP/MESH/WHEAT"));
            Object.Destroy(GameObject.Find("MAP/MESH/LAKEBED"));
            Object.Destroy(GameObject.Find("MAP/MESH/TREES1_COLL"));
            Object.Destroy(GameObject.Find("MAP/MESH/TREES2_COLL"));
            Object.Destroy(GameObject.Find("MAP/MESH/TREES3_COLL"));
            Object.Destroy(GameObject.Find("MAP/MESH/ELEC_POLES"));
            Object.Destroy(GameObject.Find("PERAJARVI/HouseBig"));
            Object.Destroy(GameObject.Find("PERAJARVI/CHURCH"));
            Object.Destroy(GameObject.Find("PERAJARVI/HouseSmall3"));
            Object.Destroy(GameObject.Find("PERAJARVI/DustCloudLOD1"));
            Object.Destroy(GameObject.Find("PERAJARVI/HouseRinatama3"));
            Object.Destroy(GameObject.Find("PERAJARVI/Old3"));
            Object.Destroy(GameObject.Find("PERAJARVI/TerraceHouse"));
            Object.Destroy(GameObject.Find("PERAJARVI/School"));
            Object.Destroy(GameObject.Find("PERAJARVI/HouseWhite"));
            Object.Destroy(GameObject.Find("PERAJARVI/HouseOld1"));
            Object.Destroy(GameObject.Find("PERAJARVI/HouseRinatama2"));
            Object.Destroy(GameObject.Find("PERAJARVI/MessageBoard"));
        }

        private void Mod_Update()
        {
            Object.Destroy(GameObject.Find("COPS"));
            Object.Destroy(GameObject.Find("HUMANS"));
            Object.Destroy(GameObject.Find("Skidmarks"));
            Object.Destroy(GameObject.Find("RYKIPOHJA"));
            Object.Destroy(GameObject.Find("SOCCER"));
            Object.Destroy(GameObject.Find("NPC_CARS"));
            Object.Destroy(GameObject.Find("ElectricityBills"));
            Object.Destroy(GameObject.Find("PlayerWanted"));
            Object.Destroy(GameObject.Find("RALLY"));
            Object.Destroy(GameObject.Find("AnimalsMoose"));
            Object.Destroy(GameObject.Find("TRAFFIC"));
        }
    }
}
