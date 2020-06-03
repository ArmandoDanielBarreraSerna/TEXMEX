using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXMEX.Models
{
    class FoodOrganizador : iProductos
    {
        public List<Burromexa> burroMexa;
        public List<Hamburmexa> hamburMexa;
        public List<Nacheesse> nacheesse;
        public List<HotDog> hotDog;

        public FoodOrganizador()
        {
            burroMexa = new List<Burromexa>();
            hamburMexa = new List<Hamburmexa>();
            nacheesse = new List<Nacheesse>();
            hotDog = new List<HotDog>();
        }

        public void Visitar(Burromexa food)
        {
            burroMexa.Add(food);
        }

        public void Visitar(HotDog food)
        {
            hotDog.Add(food);
        }

        public void Visitar(Hamburmexa food)
        {
            hamburMexa.Add(food);
        }

        public void Visitar(Nacheesse food)
        {
            nacheesse.Add(food);
        }
    }
}
