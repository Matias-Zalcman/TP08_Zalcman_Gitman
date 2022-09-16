using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TP08_Zalcman_Gitman.Models;

namespace TP08_Zalcman_Gitman.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.listadoSeries = BD.ListarSeries();
        return View();
    }

    public List<Temporadas> VerTemporadasAjax(int IdSerie)
    {
        return BD.ListarTemporadas(IdSerie);
    }

    public List<Actores> VerActoresAjax(int IdSerie)
    {
        return BD.ListarActores(IdSerie);
    }

    public Series VerInfoSerieAjax(int IdSerie)
    {
        return BD.VerInfoSerie(IdSerie);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
