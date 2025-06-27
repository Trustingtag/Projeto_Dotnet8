using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Projeto_Dotnet8.Models;
using Projeto_Dotnet8.Repository;

namespace Projeto_Dotnet8.Controllers;

public class Computador : Controller
{
    private readonly IcomputadorRepository computadorRepository;
    private readonly ISalaRepository salaRepository; // Adicione isso

    public Computador(IcomputadorRepository computador_Repository, ISalaRepository salaRepository)
    {
        computadorRepository = computador_Repository;
        this.salaRepository = salaRepository;
    }

    public IActionResult Index()
    {
        return RedirectToAction("Index", "Principal");
    }

    public IActionResult Editar()
    {
        return View();
    }

    public IActionResult Criar()
    {
        return View();
    }
    public IActionResult CriarPC()
    {
        var viewModel = new CriarPC_Sala
        {
            Computador = new ComputadorModels(),
            Salas = salaRepository.ListarSalas() // Você vai precisar criar esse método
        };
        return View(viewModel);
    }
    [HttpPost]
    public IActionResult CriarPC(CriarPC_Sala model)
    {
        if (!string.IsNullOrWhiteSpace(model.NovaSalaNum))
        {
            var novaSala = new SalaModels { Sala_Num = model.NovaSalaNum };
            salaRepository.adicionar(novaSala);
            model.SalaSelecionadaId = novaSala.ID;
        }

        // Validação: Limite de 5 computadores por sala
        int salaId = (model.SalaSelecionadaId != 0) ? model.SalaSelecionadaId : 0;
        var computadoresNaSala = computadorRepository.ListarPorSala(salaId)?.Count() ?? 0;
        if (computadoresNaSala >= 5)
        {
            ModelState.AddModelError("", "Esta sala já possui o limite de 5 computadores.");
            model.Salas = salaRepository.ListarSalas(); // Recarrega as salas para a view
            return View(model);
        }

        if (salaId != 0)
        {
            var computador = model.Computador;
            computador.SalaModelsID = salaId;
            computadorRepository.adicionar(computador);
        }
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
