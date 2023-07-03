using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    internal class Cuadrado : FormaGeometrica, IFormaGeometrica
    {
        ResourceManager Resources = new ResourceManager(typeof(Properties.Resources));
        public Cuadrado(decimal ancho) : base(ancho)
        {
            Tipo = Cuadrado;
        }

        public override decimal CalcularArea()
        {
            return _lado * _lado;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 4;
        }

        //public new string TraducirForma(int cantidad, int idioma)
        //{
        //    return (cantidad > 1 ? Resources.GetString("Cuadrados" + idioma) : Resources.GetString("Cuadrado" + idioma));
        //}
    }
}
