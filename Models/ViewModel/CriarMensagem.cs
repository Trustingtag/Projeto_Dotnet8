using System.Collections.Generic;

namespace Projeto_Dotnet8.Models.ViewModel
{
    public class CriarMensagem
    {
        public int SalaId { get; set; }
        public List<SalaModels> Salas { get; set; }
        public int ComputadorId { get; set; }
        public List<ComputadorModels> Computadores { get; set; }
        public string Mensagem { get; set; }
    }
}