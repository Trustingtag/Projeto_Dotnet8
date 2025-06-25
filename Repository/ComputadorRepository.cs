using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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



    }
}