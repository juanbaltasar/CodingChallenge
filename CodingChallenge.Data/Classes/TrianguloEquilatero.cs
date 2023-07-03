using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    internal class TrianguloEquilatero : FormaGeometrica, IFormaGeometrica
    {
        ResourceManager Resources = new ResourceManager(typeof(Properties.Resources));
        public TrianguloEquilatero(decimal ancho) : base(ancho)
        {
            Tipo = TrianguloEquilatero;
        }

        public override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 3;
        }
    }
}
