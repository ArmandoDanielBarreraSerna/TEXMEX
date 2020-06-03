using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXMEX.Models
{
    public class FoodContador : iProductos
    {
        public string total;
        public float añadir;

        public FoodContador()
        {
            total = "";
        }
        public void Visitar(Hamburmexa food)
        {

            total = food.Valor;
        }
        public void Visitar(HotDog food)
        {
            total = food.Valor;
        }

        public void Visitar(Nacheesse food)
        {
            total = food.Valor;
        }

        public void Visitar(Burromexa food)
        {
            total = food.Valor;
        }
    }
}
