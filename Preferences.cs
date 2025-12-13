// ReSharper disable MemberCanBePrivate.Global, these categories may be used outside of this namespace to create bonemenu options.
using MelonLoader.Utils;

namespace WeatherElectric.InfiniteAmmo.Melon;

internal static class Preferences
{
    public static readonly MelonPreferences_Category OwnCategory = MelonPreferences.CreateCategory("InfiniteAmmo");
    
    public static MelonPreferences_Entry<bool> Enabled { get; set; }

    public static void Setup()
    {
        Enabled = OwnCategory.CreateEntry("Enabled", true, "Enabled",
            "Whether the mod is enabled or not");
        OwnCategory.SetFilePath(MelonPrefs.Preferences.FilePath);
        OwnCategory.SaveToFile(false);
        Main.Logger.Log("Finished preferences setup for InfiniteAmmo", LogLevel.Debug);
    }
}