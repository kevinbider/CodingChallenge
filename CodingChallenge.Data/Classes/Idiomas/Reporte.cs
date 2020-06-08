using CodingChallenge.Data.Classes.Operaciones;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes.Idiomas
{
    public class Reporte
    {
        public static string Imprimir(List<IFormaGeometrica> formas, IIdioma idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {

                sb.Append(idioma.Header(true));
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                sb.Append(idioma.Header(false));

                formas = formas.OrderBy(t => t.tipo).ToList();

                Operacion operaciones = new Operacion(formas);

                foreach (var cont in operaciones.Contador)
                {
                    sb.Append(idioma.Linea(cont.Cantidad, cont.TotalAreas, cont.TotalPerimetro, cont.Figura));
                }

                sb.Append(idioma.Footer(operaciones.ContadorTotal.Cantidad, operaciones.ContadorTotal.TotalAreas, operaciones.ContadorTotal.TotalPerimetro));
            }           

            return sb.ToString();
        }
    }
}
