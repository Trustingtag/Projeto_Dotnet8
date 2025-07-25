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

    /* Levando os dados para o Listar da controller Principal */
    public IActionResult Listar()
    {
        List<ComputadorModels> computadores = sala_Repository.ListarComputadores();
        return View("~/Views/Principal/Listar.cshtml", computadores);
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
