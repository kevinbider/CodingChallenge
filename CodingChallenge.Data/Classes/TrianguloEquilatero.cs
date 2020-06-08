using CodingChallenge.Data.Enums;
using System;

namespace CodingChallenge.Data.Classes
{
    public class TrianguloEquilatero : IFormaGeometrica
    {
        public decimal _lado { get; private set; }

        public FormasEnum tipo { get; private set; } = FormasEnum.Triangulo;

        public TrianguloEquilatero(decimal _lado)
        {
            this._lado = _lado;
        }
        public decimal Area()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }

        public decimal Perimetro()
        {
            return _lado * 3;
        }
    }
}
