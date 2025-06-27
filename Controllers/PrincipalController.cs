using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Projeto_Dotnet8.Data;
using Projeto_Dotnet8.Models;
using Projeto_Dotnet8.Models.ViewModel;
using Projeto_Dotnet8.Repository;
namespace Reserva.Controllers;

public class Principal : Controller
{
    private readonly ILogger<Principal> _logger;
    private readonly IcomputadorRepository computadorRepository;
    private readonly ISalaRepository salaRepository; // Adicionado para gerenciar salas
    private readonly BancoContext _context; // Corrija o tipo aqui

    public Principal(ILogger<Principal> logger, IcomputadorRepository computadorRepository, ISalaRepository salaRepository, BancoContext context)
    {
        _logger = logger;
        this.computadorRepository = computadorRepository;
        this.salaRepository = salaRepository;
        _context = context; // Corrija o tipo aqui
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Listar()
    {
        var computadores = computadorRepository.ListarComputadores();
        return View(computadores);
    }

    public IActionResult Criar()
    {
        var salas = salaRepository.ListarSalas();
        var viewModel = new CriarMensagem
        {
            Salas = salas,
            Computadores = new List<ComputadorModels>() // Inicialmente vazio
        };
        return View(viewModel);
    }

    [HttpPost]
    public IActionResult Criar(CriarMensagem model, string carregar)
    {
        // Se o usuário clicou em "Carregar Computadores"
        if (!string.IsNullOrEmpty(carregar))
        {
            model.Salas = salaRepository.ListarSalas();
            model.Computadores = model.SalaId != 0
                ? computadorRepository.ListarPorSala(model.SalaId)
                : new List<ComputadorModels>();
            return View(model);
        }

        // Se for envio final do formulário
        if (!string.IsNullOrWhiteSpace(model.Mensagem) && model.ComputadorId != 0)
        {
            var mensagem = new MensagemModels
            {
                Texto = model.Mensagem,
                ComputadorID = model.ComputadorId
            };
            _context.Mensagens.Add(mensagem);
            _context.SaveChanges();
            return RedirectToAction("Listar");
        }

        // Se algo der errado, recarregue as listas
        model.Salas = salaRepository.ListarSalas();
        model.Computadores = model.SalaId != 0
            ? computadorRepository.ListarPorSala(model.SalaId)
            : new List<ComputadorModels>();
        return View(model);
    }

    public IActionResult Editar()
    {
        var computadores = computadorRepository.ListarComputadores(); // Deve retornar List<ComputadorModels>
        return View(computadores);
    }

    public IActionResult Deletar(int id)
    {
        var computador = computadorRepository.BuscarPorId(id);
        if (computador == null)
            return NotFound();

        return View(computador);
    }

    [HttpPost, ActionName("Deletar")]
    public IActionResult DeletarConfirmado(int id)
    {
        computadorRepository.Deletar(id);
        return RedirectToAction("Editar");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
