using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Projeto_Dotnet8.Models;
using Projeto_Dotnet8.Repository;

namespace Projeto_Dotnet8.Controllers;

public class Sala : Controller
{
    private readonly ISalaRepository sala_Repository;

    public Sala(ISalaRepository salaRepository)
    {
        sala_Repository = salaRepository;
    }


    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Listar()
    {
        return View();
    }

    public IActionResult Criar()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Criar(SalaModels sala)
    {
        sala_Repository.adicionar(sala);
        return RedirectToAction("Index");
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
