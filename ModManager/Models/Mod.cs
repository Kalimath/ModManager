namespace ModManager.Models;

public class Mod
{
    public string Name { get; set; }

    public Mod(string name)
    {
        Name = name;
    }
}