using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    internal class Circulo : FormaGeometrica, IFormaGeometrica
    {
        ResourceManager Resources = new ResourceManager(typeof(Properties.Resources));
        public Circulo(decimal ancho) : base(ancho)
        {
            Tipo = Circulo;
        }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _lado;
        }
    }
}
