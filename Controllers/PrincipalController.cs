using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Projeto_Dotnet8.Models;

namespace Projeto_Dotnet8.Controllers;

public class Principal : Controller
{
    private readonly ILogger<Principal> _logger;

    public Principal(ILogger<Principal> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Editar()
    {
        return View();
    }

    public IActionResult Criar()
    {
        return View();
    }

    public IActionResult Excluir()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
