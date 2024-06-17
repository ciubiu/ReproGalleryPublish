using Microsoft.AspNetCore.Mvc;
using ReproGallery.Models;
using System.Diagnostics;

namespace ReproGallery.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IReproRepository _reproRepository;

    public HomeController(ILogger<HomeController> logger, IReproRepository reproRepository)
    {
        _logger = logger;
        _reproRepository = reproRepository;
    }

    public IActionResult Index()
    {
        // 4 mean: 3 less than max number of repros
        var reprosCount = _reproRepository.AllRepros.Count() - 4;
        int rnd = new Random().Next(0, reprosCount);
        var randomRepros = _reproRepository.AllRepros.Skip(rnd).Take(3);

        return View(randomRepros);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
