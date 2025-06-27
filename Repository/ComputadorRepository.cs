using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projeto_Dotnet8.Controllers;
using Projeto_Dotnet8.Data;
using Projeto_Dotnet8.Models;

namespace Projeto_Dotnet8.Repository
{
    public class ComputadorRepository : IcomputadorRepository
    {
        private readonly BancoContext computador_Context;
        public ComputadorRepository(BancoContext computadorContext)
        {
            computador_Context = computadorContext;
        }

        public ComputadorModels adicionar(ComputadorModels Computador)
        {
            computador_Context.Computadores.Add(Computador);
            computador_Context.SaveChanges();
            return Computador;
        }

        public List<ComputadorModels> ListarPorSala(int salaId)
        {
            return computador_Context.Computadores.Where(c => c.SalaModelsID == salaId).ToList();
        }


        public IEnumerable<ComputadorModels> ListarComputadores()
        {
            return computador_Context.Computadores
                .Include(c => c.Mensagens)
                .ToList();
        }

        public ComputadorModels BuscarPorId(int id)
        {
            return computador_Context.Computadores.FirstOrDefault(c => c.ID == id);
        }

        public void Deletar(int id)
        {
            var computador = BuscarPorId(id);
            if (computador != null)
            {
                computador_Context.Computadores.Remove(computador);
                computador_Context.SaveChanges();
            }
        }
    }
}