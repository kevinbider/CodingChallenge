using CodingChallenge.Data.Enums;

namespace CodingChallenge.Data.Classes.Idiomas
{
    public class Frances : IIdioma
    {
        public string Header(bool vacio)
        {
            return vacio ? "<h1>Liste vide de formes!</h1>" : "<h1>Formes de formulaire</h1>";
        }

        public string Linea(int cantidad, decimal area, decimal perimetro, FormasEnum tipo)
        {

            if (cantidad == 1)
            {
                return $"{cantidad} {(FrancesEnum)tipo} | Région {area:#.##} | Périmètre {perimetro:#.##} <br/>";

            }
            return $"{cantidad} {(FrancesEnum)tipo}s | Région {area:#.##} | Périmètre {perimetro:#.##} <br/>";
        }
        public string Footer(int totalFiguras, decimal totalAreas, decimal totalPerimetro)
        {

            return "TOTAL:<br/>" + totalFiguras + " formes " + "Périmètre " + totalPerimetro.ToString("#.##") + " Région " + totalAreas.ToString("#.##");
        }
    }
}
