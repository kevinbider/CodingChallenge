using CodingChallenge.Data.Enums;

namespace CodingChallenge.Data.Classes.Idiomas
{
    public interface IIdioma
    {
        string Header(bool vacio);
        string Linea(int cantidad, decimal area, decimal perimetro, FormasEnum tipo);
        string Footer(int totalFiguras, decimal totalAreas, decimal totalPerimetro);
    }
}
