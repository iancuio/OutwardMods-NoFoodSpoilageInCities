using BepInEx;
using HarmonyLib;
using UnityEngine.SceneManagement;

namespace NoFoodSpoilageInCitiesMod
{
    [BepInPlugin("com.iancula.nofoodspoilageincities", "No Spoilage in Cities", "1.0.0")]
    public class NoFoodSpoilageInCitiesPlugin : BaseUnityPlugin
    {
        public static NoFoodSpoilageInCitiesPlugin Instance;

        void Awake()
        {
            Instance = this;

            var harmony = new Harmony("com.iancula.nofoodspoilageincities");
            harmony.PatchAll();

            Logger.LogInfo("No Food Spoilage In Cities mod loaded!");
        }

        public static bool IsInCity()
        {
            string scene = SceneManager.GetActiveScene().name;

            return scene.Contains("Cierzo") ||
                   scene.Contains("Berg") ||
                   scene.Contains("Monsoon") ||
                   scene.Contains("Levant") ||
                   scene.Contains("Harmattan");
        }
    }
}