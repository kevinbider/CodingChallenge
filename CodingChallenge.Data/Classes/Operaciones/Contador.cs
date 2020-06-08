using CodingChallenge.Data.Enums;

namespace CodingChallenge.Data.Classes.Operaciones
{
    public class Contador
    {
        public FormasEnum Figura { get; set; }
        public int Cantidad { get; set; }
        public decimal TotalAreas { get; set; }
        public decimal TotalPerimetro { get; set; }

        public Contador() {
            Cantidad = 0;
            TotalAreas = 0m;
            TotalPerimetro = 0m;
        }
       
    }
}
