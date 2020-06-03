using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXMEX.Models
{
    public class Hamburmexa : iFood
    {
        public string Valor = "Hamburmexa con";
        public void Aceptar(iProductos visitor)
        {
            visitor.Visitar(this);
        }
    }
}
