using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXMEX.Models
{
    public class Burromexa : iFood
    {
        public string Valor = "Burromexa con";
        public void Aceptar(iProductos visitor)
        {
            visitor.Visitar(this);
        }

        public List<Ingredientes> Ingredientes { get; set; }
        public Burromexa()
        {
            this.Ingredientes = new List<Ingredientes>();
        }

        public Burromexa(List<Ingredientes> ingredientes)
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
