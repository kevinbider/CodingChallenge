using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Classes.Idiomas;
using NUnit.Framework;
using System.Collections.Generic;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests2
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                Reporte.Imprimir(new List<IFormaGeometrica>(), new Castellano()));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                Reporte.Imprimir(new List<IFormaGeometrica>(), new Ingles() ));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            List<IFormaGeometrica> cuadrados = new List<IFormaGeometrica> { new Cuadrado(5) };

            var resumen = Reporte.Imprimir(cuadrados, new Castellano());

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3),
            };

            var resumen = Reporte.Imprimir(cuadrados, new Ingles());

            NUnit.Framework.Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = Reporte.Imprimir(formas, new Ingles());


            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = Reporte.Imprimir(formas, new Castellano());

           Assert.AreEqual("<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }
        
        #region Mis Test

        [TestCase]
        public void TestResumenListaVaciaFrances()
        {
            Assert.AreEqual("<h1>Liste vide de formes!</h1>",
                Reporte.Imprimir(new List<IFormaGeometrica>(), new Frances()));
        }      

        [TestCase]
        public void TestResumenListaConUnTrapecio()
        {
            List<IFormaGeometrica> Trapecios = new List<IFormaGeometrica> { new Trapecio(5,4,3,3.2m) };

            var resumen = Reporte.Imprimir(Trapecios, new Frances());

            Assert.AreEqual("<h1>Formes de formulaire</h1>1 Trapèze | Région 20,98 | Périmètre 15,2 <br/>TOTAL:<br/>1 formes Périmètre 15,2 Région 20,98", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados2()
        {
            var cuadrados = new List<IFormaGeometrica>
            {
                new Rectangulo(5,2),
                new Rectangulo(1,4),
                new Rectangulo(3,2),
            };

            var resumen = Reporte.Imprimir(cuadrados, new Frances());

            Assert.AreEqual("<h1>Formes de formulaire</h1>3 Rectangles | Région 20 | Périmètre 34 <br/>TOTAL:<br/>3 formes Périmètre 34 Région 20", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos2()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m),
                new Trapecio(5,3,4,3),
                new Rectangulo(5,3)
            };

            var resumen = Reporte.Imprimir(formas, new Frances());


            Assert.AreEqual(
                "<h1>Formes de formulaire</h1>2 Carrés | Région 29 | Périmètre 28 <br/>2 Cercles | Région 13,01 | Périmètre 18,06 <br/>3 Triangles | Région 49,64 | Périmètre 51,6 <br/>1 Trapèze | Région 18,88 | Périmètre 15 <br/>1 Rectangle | Région 15 | Périmètre 16 <br/>TOTAL:<br/>9 formes Périmètre 128,66 Région 125,53",
                resumen);
        }
        #endregion Mis Test
    }
}
