namespace TestDrive.Models
{
    public class Veiculo
    {
        public string Modelo { get; set; }
        public decimal Preco { get; set; }
        public string PrecoFormatado {
            get { return string.Format("R$ {0}", Preco); }
        }
    }
}
