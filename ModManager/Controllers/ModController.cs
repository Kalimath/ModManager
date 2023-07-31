using Microsoft.AspNetCore.Mvc;
using ModManager.Streaming;

namespace ModManager.Controllers;

public class ModController : Controller
{
    public ModStream ModStream { get; set; }
    
    public ModController()
    {
        ModStream = new ModStream();
    }

    // GET
    public IActionResult Index()
    {
        return View(ModStream.GetMods());
    }

    public IActionResult Details(string modName)
    {
        return View(ModStream.GetMod(modName));
    }
}