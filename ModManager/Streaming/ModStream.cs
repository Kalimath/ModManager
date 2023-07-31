using ModManager.Extensions;
using ModManager.Models;

namespace ModManager.Streaming;

public class ModStream
{
    private List<Mod> _mods = null;
    private const string ModsFolder = $"C:\\Users\\mathi\\Documents\\My Games\\FarmingSimulator2022\\mods\\modManagerTestModsFolder";
    private const string ModNamePrefix = "FS22_";
    
    
    //method returns all zip-file names
    public List<Mod> GetMods()
    {
        if (_mods is null || _mods.Count == 0)
        {
            var fileNames = Directory.GetFiles(ModsFolder);
            _mods = fileNames.Select(name => new Mod(name.TrimModName(ModNamePrefix))).ToList();
        }
        return _mods;
    }
    
    public Mod GetMod(string modName)
    {
        return GetMods().FirstOrDefault(mod => mod.Name == modName)!;
    }
}