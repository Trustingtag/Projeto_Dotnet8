using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_Dotnet8.Data;
using Projeto_Dotnet8.Models;

namespace Projeto_Dotnet8.Repository
{
    public class SalaRepository : ISalaRepository
    {
        private readonly BancoContext salaContext;

        public SalaRepository(BancoContext sala_Context)
        {
            salaContext = sala_Context;
        }

        public SalaModels adicionar(SalaModels Sala)
        {
            salaContext.Salas.Add(Sala);
            salaContext.SaveChanges();
            return Sala;
        }

        //Utilizando a sala para fazer a listagem dos computadores
        public List<ComputadorModels> ListarComputadores()
        {
            return salaContext.Computadores.ToList();
        }

        public List<SalaModels> ListarSalas()
        {
            return salaContext.Salas.ToList();
        }
    }
}