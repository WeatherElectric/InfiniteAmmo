[assembly: AssemblyTitle(WeatherElectric.InfiniteAmmo.Main.Description)]
[assembly: AssemblyDescription(WeatherElectric.InfiniteAmmo.Main.Description)]
[assembly: AssemblyCompany(WeatherElectric.InfiniteAmmo.Main.Company)]
[assembly: AssemblyProduct(WeatherElectric.InfiniteAmmo.Main.Name)]
[assembly: AssemblyCopyright("Developed by " + WeatherElectric.InfiniteAmmo.Main.Author)]
[assembly: AssemblyTrademark(WeatherElectric.InfiniteAmmo.Main.Company)]
[assembly: AssemblyVersion(WeatherElectric.InfiniteAmmo.Main.Version)]
[assembly: AssemblyFileVersion(WeatherElectric.InfiniteAmmo.Main.Version)]
[assembly:
    MelonInfo(typeof(WeatherElectric.InfiniteAmmo.Main), WeatherElectric.InfiniteAmmo.Main.Name,
        WeatherElectric.InfiniteAmmo.Main.Version,
        WeatherElectric.InfiniteAmmo.Main.Author, WeatherElectric.InfiniteAmmo.Main.DownloadLink)]
[assembly: MelonColor(255, 255, 235, 0)]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame("Stress Level Zero", "BONELAB")]