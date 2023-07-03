using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    internal interface IListaFormas
    {
        string TraducirForma(int tipo, int idioma, int cantFormas);
        string ObtenerLinea(int idioma);
    }
}
