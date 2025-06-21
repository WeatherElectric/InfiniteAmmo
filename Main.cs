using BoneLib;
using Il2CppSLZ.Marrow;

namespace WeatherElectric.InfiniteAmmo;

public class Main : MelonMod
{
    internal const string Name = "InfiniteAmmo";
    internal const string Description = "Infinite ammo. What else?";
    internal const string Author = "Mabel Amber";
    internal const string Company = "Weather Electric";
    internal const string Version = "1.2.0";
    internal const string DownloadLink = "https://thunderstore.io/c/bonelab/p/SoulWithMae/InfiniteAmmo/";

    public override void OnInitializeMelon()
    {
        ModConsole.Setup(LoggerInstance);
        Preferences.Setup();
        Hooking.OnGrabObject += OnGrabObject;
    }

    private static void OnGrabObject(GameObject gameObject, Hand hand)
    {
        if (AmmoManager.HasAmmo()) return;
        var gun = gameObject.GetComponent<Gun>();
        if (!gun) return;
        AmmoManager.AddAmmo();
    }
}