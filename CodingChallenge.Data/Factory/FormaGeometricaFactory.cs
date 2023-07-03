using CodingChallenge.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Factory
{
    public class FormaGeometricaFactory
    {
        public static FormaGeometrica Create(int tipo, decimal ancho, decimal alto = 0)
        {
            switch (tipo)
            {
                case FormaGeometrica.Cuadrado:
                    return new Cuadrado(ancho);
                case FormaGeometrica.Circulo:
                    return new Circulo(ancho);
                case FormaGeometrica.TrianguloEquilatero:
                    return new TrianguloEquilatero(ancho);
                case FormaGeometrica.Trapecio:
                    return new Trapecio(ancho, alto);

                default: return null;
            }
        }
    }
}
