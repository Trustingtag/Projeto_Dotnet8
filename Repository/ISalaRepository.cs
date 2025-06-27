using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_Dotnet8.Models;

namespace Projeto_Dotnet8.Repository
{
    public interface ISalaRepository
    {
        /* Criação dos métodos OBRIGATÓRIOS a existir  */
        SalaModels adicionar(SalaModels Sala);
        List<ComputadorModels> ListarComputadores();
        List<SalaModels> ListarSalas();
    }
}