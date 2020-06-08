using System;
using System.Collections.Generic;

namespace CodingChallenge.Data.Classes.Operaciones
{
    public class Operacion
    {
        public Contador ContadorTotal { get; private set; }
        public List<Contador> Contador { get; private set; }

        public Operacion(List<IFormaGeometrica> formas) {
            Contador = this.ContarFiguras(formas);
        }

        private List<Contador> ContarFiguras(List<IFormaGeometrica> formas)
        {
            int indice = 0;

            //Esta lista tiene los numeros por figura geometrica
            List<Contador> listaContadores = new List<Contador>();

            this.ContadorTotal = new Contador();

            Contador contadorAux;

            while (indice < formas.Count)
            {
                contadorAux = new Contador()
                {
                    Figura = formas[indice].tipo
                };

                //Inicio Proceso de "una" figura geometrica
                while (indice < formas.Count && contadorAux.Figura == formas[indice].tipo)
                {
                    //Este es para el contador por figura
                    contadorAux.Cantidad += 1;
                    contadorAux.TotalAreas = Decimal.Add(contadorAux.TotalAreas, formas[indice].Area());
                    contadorAux.TotalPerimetro = Decimal.Add(contadorAux.TotalPerimetro, formas[indice].Perimetro());

                    //Este es para el contador general (Todas las figuras)
                    ContadorTotal.Cantidad += 1;
                    ContadorTotal.TotalAreas = Decimal.Add(ContadorTotal.TotalAreas, formas[indice].Area());
                    ContadorTotal.TotalPerimetro = Decimal.Add(ContadorTotal.TotalPerimetro, formas[indice].Perimetro());

                    indice += 1;
                }
                //Fin Proceso de la figura geometrica

                listaContadores.Add(contadorAux);
            }
            
            return listaContadores;
        }
        
    }
}
