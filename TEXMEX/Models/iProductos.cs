using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEXMEX.Models;

namespace TEXMEX.Models
{
        public interface iProductos
        {
            void Visitar(Burromexa food);
            void Visitar(HotDog food);
            void Visitar(Hamburmexa food);
            void Visitar(Nacheesse food);
        }
}
