using MelonLoader.Logging;

namespace WeatherElectric.InfiniteAmmo;

public class Main : MelonMod
{
    internal const string Name = "InfiniteAmmo";
    internal const string Description = "Infinite ammo. What else?";
    internal const string Author = "Mabel Amber";
    internal const string Company = "Weather Electric";
    internal const string Version = "1.3.0";
    internal const string DownloadLink = "https://thunderstore.io/c/bonelab/p/WeatherElectric/InfiniteAmmo/";

    internal static LoggerInstance Logger;
    
    public override void OnInitializeMelon()
    {
        Logger = new LoggerInstance(LoggerInstance);
        Preferences.Setup();
    }
}