using CodingChallenge.Data.Enums;

namespace CodingChallenge.Data.Classes.Idiomas
{
    public class Castellano : IIdioma
    {
        public string Header(bool vacio) {
            return vacio ? "<h1>Lista vacía de formas!</h1>" : "<h1>Reporte de Formas</h1>";
        }

        public string Linea(int cantidad, decimal area, decimal perimetro, FormasEnum tipo)
        {

            if (cantidad == 1)
            {
                return $"{cantidad} {(CastellanoEnum)tipo} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";

            }
            return $"{cantidad} {(CastellanoEnum)tipo}s | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";
        }
        public string Footer(int totalFiguras, decimal totalAreas, decimal totalPerimetro) {

            return "TOTAL:<br/>" + totalFiguras + " formas " + "Perimetro " + totalPerimetro.ToString("#.##") + " Area " + totalAreas.ToString("#.##");
        }
    }
}
