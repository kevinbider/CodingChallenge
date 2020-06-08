using CodingChallenge.Data.Enums;
using System;

namespace CodingChallenge.Data.Classes
{
    public class Circulo : IFormaGeometrica
    {
        public decimal _lado { get; private set; }

        public FormasEnum tipo { get; private set; } = FormasEnum.Circulo;
        
        public Circulo(decimal _lado) {
            this._lado = _lado;
        }

        public decimal Area()
        {
            return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
        }

        public decimal Perimetro()
        {
            return (decimal)Math.PI * _lado;
        }
    }
}
