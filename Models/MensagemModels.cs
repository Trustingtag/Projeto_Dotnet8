namespace Projeto_Dotnet8.Models
{
    public class MensagemModels
    {
        public int ID { get; set; }
        public int ComputadorID { get; set; }
        public ComputadorModels Computador { get; set; }
        public string Texto { get; set; }
    }
}