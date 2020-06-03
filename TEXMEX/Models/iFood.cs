using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXMEX.Models
{
    public interface iFood
    {
        void Aceptar(iProductos visitor);
    }
}
