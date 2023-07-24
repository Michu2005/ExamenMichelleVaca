using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenMichelleVaca
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }
        public float Quantity { get; set; }
        public override string ToString()
        {
            return $"{Id}\t{Description} \n\t"
                + $"Measurement..............: \t{Measurement} \n\t"
                + $"Quantity.................: \t{Quantity, 20:F2} \n\t"
                + $"Price....................: \t{Price,20:C2} \n\t"
                + $"Tax......................: \t{Tax,20:P2} \n\t"
                + $"Value....................: \t{ValueToPay(),20:C2}\n";
        }

        public override decimal ValueToPay()
        {
            return Price * (decimal)Quantity * (decimal)(1 + Tax);
        }
    }
}
