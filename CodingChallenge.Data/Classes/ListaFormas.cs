using CodingChallenge.Data.Properties;
using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    internal class ListaFormas : IListaFormas
    {
        ResourceManager Resources = new ResourceManager(typeof(Properties.Resources));
        List<FormaGeometrica> formas = new List<FormaGeometrica>();
        int numeroCuadrados = 0;
        int numeroCirculos = 0;
        int numeroTriangulos = 0;
        int numeroTrapecios = 0;

        decimal areaCirculos = 0m;
        decimal areaCuadrados = 0m;
        decimal areaTriangulos = 0m;
        decimal areaTrapecios = 0m;

        decimal perimetroCuadrados = 0m;
        decimal perimetroCirculos = 0m;
        decimal perimetroTriangulos = 0m;
        decimal perimetroTrapecios = 0m;
        public ListaFormas(List<FormaGeometrica> lista) 
        {
            formas = lista;
        }
        public string ObtenerLinea(int idioma)
        {
            StringBuilder sb = new StringBuilder();

            RealizarConteo();

            if (formas.Count > 0)
            {
                if (numeroCuadrados > 0)
                    sb.Append($"{numeroCuadrados} {TraducirForma(FormaGeometrica.Cuadrado, idioma, numeroCuadrados)} | Area {areaCuadrados:#.##} | {Resources.GetString("Perimetro" + idioma)} {perimetroCuadrados:#.##} <br/>");
                if (numeroCirculos > 0)
                    sb.Append($"{numeroCirculos} {TraducirForma(FormaGeometrica.Circulo, idioma, numeroCirculos)} | Area {areaCirculos:#.##} | {Resources.GetString("Perimetro" + idioma)} {perimetroCirculos:#.##} <br/>");
                if (numeroTriangulos > 0)
                    sb.Append($"{numeroTriangulos} {TraducirForma(FormaGeometrica.TrianguloEquilatero, idioma, numeroTriangulos)} | Area {areaTriangulos:#.##} | {Resources.GetString("Perimetro" + idioma)} {perimetroTriangulos:#.##} <br/>");
                if (numeroTrapecios > 0)
                    sb.Append($"{numeroTrapecios} {TraducirForma(FormaGeometrica.Trapecio, idioma, numeroTrapecios)} | Area {areaTrapecios:#.##} | {Resources.GetString("Perimetro" + idioma)} {perimetroTrapecios:#.##} <br/>");

                sb.Append("TOTAL:<br/>");
                sb.Append(numeroCuadrados + numeroCirculos + numeroTriangulos + numeroTrapecios + " " + Resources.GetString("Formas" + idioma) + " ");
                sb.Append(Resources.GetString("Perimetro" + idioma) + " " + (perimetroCuadrados + perimetroTriangulos + perimetroCirculos + perimetroTrapecios).ToString("#.##") + " ");
                sb.Append("Area " + (areaCuadrados + areaCirculos + areaTriangulos + areaTrapecios).ToString("#.##"));
                return sb.ToString();
            }

            return string.Empty;
        }

        private void RealizarConteo()
        {
            for (var i = 0; i < formas.Count; i++)
            {
                if (formas[i].Tipo == FormaGeometrica.Cuadrado)
                {
                    numeroCuadrados++;
                    areaCuadrados += formas[i].CalcularArea();
                    perimetroCuadrados += formas[i].CalcularPerimetro();
                }
                if (formas[i].Tipo == FormaGeometrica.Circulo)
                {
                    numeroCirculos++;
                    areaCirculos += formas[i].CalcularArea();
                    perimetroCirculos += formas[i].CalcularPerimetro();
                }
                if (formas[i].Tipo == FormaGeometrica.TrianguloEquilatero)
                {
                    numeroTriangulos++;
                    areaTriangulos += formas[i].CalcularArea();
                    perimetroTriangulos += formas[i].CalcularPerimetro();
                }
                if (formas[i].Tipo == FormaGeometrica.Trapecio)
                {
                    numeroTrapecios++;
                    areaTrapecios += formas[i].CalcularArea();
                    perimetroTrapecios += formas[i].CalcularPerimetro();
                }
            }
        }

        public string TraducirForma(int tipo, int idioma, int cantFormas)
        {
            switch (tipo)
            {
                case FormaGeometrica.Cuadrado:
                    return cantFormas == 1 ? Resources.GetString("Cuadrado" + idioma) : Resources.GetString("Cuadrados" + idioma);
                case FormaGeometrica.Circulo:
                    return cantFormas == 1 ? Resources.GetString("Circulo" + idioma) : Resources.GetString("Circulos" + idioma);
                case FormaGeometrica.TrianguloEquilatero:
                    return cantFormas == 1 ? Resources.GetString("Triangulo" + idioma) : Resources.GetString("Triangulos" + idioma);
                case FormaGeometrica.Trapecio:
                    return cantFormas == 1 ? Resources.GetString("Trapecio" + idioma) : Resources.GetString("Trapecios" + idioma);
            }

            return string.Empty;
        }
    }
}
