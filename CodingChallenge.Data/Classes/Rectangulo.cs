using CodingChallenge.Data.Enums;

namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : IFormaGeometrica
    {
        public decimal _lado { get; private set; }
        public decimal _lado2 { get; private set; }
        public FormasEnum tipo { get; private set; } = FormasEnum.Rectangulo;


        public Rectangulo(decimal _lado, decimal _lado2)
        {
            this._lado = _lado;
            this._lado2 = _lado2;
        }
        public decimal Area()
        {
            return _lado * _lado2;
        }

        public decimal Perimetro()
        {

            return 2*(_lado + _lado2);   
        }
    }
}
