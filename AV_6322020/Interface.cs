using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV_6322020
{
    public abstract class Interface
    {
        
        public double Quantidade { get; set; }
        public double Preco { get; set; }
        public double Calcular()
        {
            return Preco * 0.05;
        }
    }
}
