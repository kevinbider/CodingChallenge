using CodingChallenge.Data.Enums;
using System;

namespace CodingChallenge.Data.Classes
{
    public class Trapecio : IFormaGeometrica
    {
        /// <summary>
        /// a
        /// </summary>
        public decimal _lado { get; private set; }
        /// <summary>
        /// b
        /// </summary>
        public decimal _lado2 { get; private set; }
        /// <summary>
        /// c
        /// </summary>
        public decimal _lado3 { get; private set; }
        /// <summary>
        /// d
        /// </summary>
        public decimal _lado4 { get; private set; }

        public FormasEnum tipo { get; private set; } = FormasEnum.Trapecio;

        public Trapecio(decimal _lado, decimal _lado2, decimal _lado3, decimal _lado4)
        {
            this._lado = _lado;
            this._lado2 = _lado2;
            this._lado3 = _lado3;
            this._lado4 = _lado4;
        }

        public decimal Area()
        {
            //variables locales
            double a = Convert.ToDouble(_lado);
            double b = Convert.ToDouble(_lado2);
            double c = Convert.ToDouble(_lado3);
            double d = Convert.ToDouble(_lado4);

            return (decimal)((a+b / 2) * Math.Sqrt(Math.Pow(c, 2) - Math.Pow((Math.Pow(c, 2) - Math.Pow(d, 2) + (Math.Pow((a-b), 2))) / (2 * (a-b)), 2)));
        }

        public decimal Perimetro()
        {
            return _lado + _lado2 + _lado3 + _lado4;
        }
    }
}
