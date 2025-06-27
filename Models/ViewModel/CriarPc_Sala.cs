using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Projeto_Dotnet8.Models
{
    public class CriarPC_Sala
    {
        public string NovaSalaNum { get; set; }
        public ComputadorModels Computador { get; set; }
        public List<SalaModels> Salas { get; set; }
        public int SalaSelecionadaId { get; set; }
    }
}