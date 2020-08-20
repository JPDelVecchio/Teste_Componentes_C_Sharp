using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InclusaoItens
{
    public class Item
    {
        public string Produto { get; set; }
        public double Quantidade { get; set; }
        public double Preco { get; set; }
        public double TotalItem { get; set; }

        public Item()
            {
            Produto = null;
            Quantidade = 0.0;
            Preco = 0.0;
            TotalItem = Preco * Quantidade;
            }
    }
}
