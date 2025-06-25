using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Projeto_Dotnet8.Models;
using Projeto_Dotnet8.Repository;

namespace Projeto_Dotnet8.Controllers;

public class Computador : Controller
{
    private readonly IcomputadorRepository computadorRepository;

    public Computador(IcomputadorRepository computador_Repository)
    {
        computadorRepository = computador_Repository;
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
    [HttpPost]
    public IActionResult Criar(ComputadorModels computador)
    {
        computadorRepository.adicionar(computador);
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
