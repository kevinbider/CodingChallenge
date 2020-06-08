using CodingChallenge.Data.Enums;

namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : IFormaGeometrica
    {
        public decimal _lado { get; private set; }

        public FormasEnum tipo { get; private set; } = FormasEnum.Cuadrado;

        public Cuadrado(decimal _lado) {
            this._lado = _lado;
        }
        public decimal Area()
        {
            return _lado * _lado;
        }

        public decimal Perimetro()
        {
            return _lado * 4;
        }
    }
}
