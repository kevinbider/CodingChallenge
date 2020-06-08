using CodingChallenge.Data.Enums;

namespace CodingChallenge.Data.Classes.Idiomas
{
    public class Ingles : IIdioma
    {
        public string Header(bool vacio)
        {
            return vacio ? "<h1>Empty list of shapes!</h1>" : "<h1>Shapes report</h1>";
        }

        public string Linea(int cantidad, decimal area, decimal perimetro, FormasEnum tipo)
        {

            if (cantidad == 1)
            {
                return $"{cantidad} {(InglesEnum)tipo} | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>";

            }
            return $"{cantidad} {(InglesEnum)tipo}s | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>";
        }
        public string Footer(int totalFiguras, decimal totalAreas, decimal totalPerimetro)
        {
            return "TOTAL:<br/>" + totalFiguras + " shapes " + "Perimeter " + totalPerimetro.ToString("#.##") + " Area " + totalAreas.ToString("#.##");
        }
    }
}
