using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_Dotnet8.Controllers;
using Projeto_Dotnet8.Models;

namespace Projeto_Dotnet8.Repository
{
    public interface IcomputadorRepository
    {
        /* Criação dos métodos OBRIGATÓRIOS a existir  */

        List<ComputadorModels> ListarPorSala(int salaId);
        ComputadorModels adicionar(ComputadorModels computador);
        IEnumerable<ComputadorModels> ListarComputadores();
        ComputadorModels BuscarPorId(int id);
        void Deletar(int id);
    }
}