using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    internal class Trapecio : FormaGeometrica, IFormaGeometrica
    {
        ResourceManager Resources = new ResourceManager(typeof(Properties.Resources));
        protected readonly decimal _altura;
        public Trapecio(decimal ancho, decimal altura) : base(ancho)
        {
            Tipo = Trapecio;
            _altura = altura;
        }

        public override decimal CalcularArea()
        {
            return _lado * _altura;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado*2 + _altura*2;
        }
    }
}
