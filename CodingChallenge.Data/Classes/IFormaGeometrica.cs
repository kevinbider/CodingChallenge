using CodingChallenge.Data.Enums;

namespace CodingChallenge.Data.Classes
{
    public interface IFormaGeometrica 
    {
        decimal _lado { get; }
        FormasEnum tipo { get; }
        decimal Area();
        decimal Perimetro();


    }
}
