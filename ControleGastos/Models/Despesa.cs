namespace ControleGastos.Models
{
    public class Despesa{
        public int Id {get; set; }
        public string Nome {get; set; } = string.Empty;
        public decimal Valor {get; set; }
        public string Categoria {get; set; } = string.Empty;
        public DateTime Data {get; set; } = DateTime.Now;
    }
}