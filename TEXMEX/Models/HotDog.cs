using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEXMEX.Models;

namespace TEXMEX.Models
{
    public class HotDog : iFood
    {
        public string Valor = "Dogo con";
        public void Aceptar(iProductos visitor)
        {
            visitor.Visitar(this);
        }

        public List<Ingredientes> Ingredientes { get; set; }
        public HotDog()
        {
            this.Ingredientes = new List<Ingredientes>();
        }

        public HotDog(List<Ingredientes> ingredientes)
        {
            this.Ingredientes = ingredientes;
        }

        public override string ToString()
        {
            string combinedS = string.Join(">>", this.Ingredientes);
            return $" {combinedS}";
        }
    }
}
