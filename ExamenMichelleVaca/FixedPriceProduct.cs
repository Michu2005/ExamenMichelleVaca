using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenMichelleVaca
{
    public class FixedPriceProduct: Product
    {
        public override string ToString()
        {
            return $"{Id}\t{Description} \n\t" 
                + $"Price....................: \t{Price, 20 :C2} \n\t"
                + $"Tax......................: \t{Tax,20:P2} \n\t"
                + $"Value....................: \t{ValueToPay(),20:C2}\n";
        }

        public override decimal ValueToPay()
        {
            return Price * (decimal)(1+Tax);
        }
    }
}
