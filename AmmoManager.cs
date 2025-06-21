using HarmonyLib;
using Il2CppSLZ.Marrow;
using Il2CppSLZ.Marrow.Data;
// ReSharper disable InconsistentNaming

namespace WeatherElectric.InfiniteAmmo;

[HarmonyPatch(typeof(AmmoInventory))]
internal static class AmmoManager
{
    private static AmmoInventory ammoInventory;
    
    [HarmonyPatch(nameof(AmmoInventory.Awake))]
    [HarmonyPostfix]
    public static void Awake(AmmoInventory __instance)
    {
        ammoInventory = __instance;
    }

    public static bool HasAmmo()
    {
        var lightAmmoCount = ammoInventory.GetCartridgeCount("light");
        var mediumAmmoCount = ammoInventory.GetCartridgeCount("medium");
        var heavyAmmoCount = ammoInventory.GetCartridgeCount("heavy");
        return lightAmmoCount != 0 || mediumAmmoCount != 0 || heavyAmmoCount != 0;
    }

    public static void AddAmmo()
    {
        if (!Preferences.Enabled.Value) return;
        
        ammoInventory.AddCartridge(ammoInventory.lightAmmoGroup, 2000);
        ammoInventory.AddCartridge(ammoInventory.mediumAmmoGroup, 2000);
        ammoInventory.AddCartridge(ammoInventory.heavyAmmoGroup, 2000);
    }

    [HarmonyPatch(nameof(AmmoInventory.RemoveCartridge))]
    [HarmonyPostfix]
    public static void RemoveCartridge(AmmoInventory __instance, CartridgeData cartridge, int count)
    {
        if (!Preferences.Enabled.Value) return;

        var group = __instance.GetGroupByCartridge(cartridge);
        if (group == null) return;

        switch (group)
        {
            case "light":
                __instance.AddCartridge(__instance.lightAmmoGroup, count);
                break;
            case "medium":
                __instance.AddCartridge(__instance.mediumAmmoGroup, count);
                break;
            case "heavy":
                __instance.AddCartridge(__instance.heavyAmmoGroup, count);
                break;
        }
    }
}