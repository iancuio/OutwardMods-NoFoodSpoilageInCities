using HarmonyLib;
using NoFoodSpoilageInCitiesMod;

[HarmonyPatch(typeof(Item), "ReduceDurability")]
public class Item_ReduceDurability_Patch
{
    static bool Prefix()
    {
        return !NoFoodSpoilageInCitiesPlugin.IsInCity();
    }
}