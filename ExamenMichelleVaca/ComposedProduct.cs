using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenMichelleVaca
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public List<Product> Products { get; set; }

        public ComposedProduct() { 
            Products = new List<Product>();
        }
        
        private string ProductName()
        {
            string result = "";
            foreach (var item in Products)
            {
                result += item.Description + ", ";
            }
            return result;
        }

        public override string ToString()
        {
            return $"{Id}\t{Description} \n\t"
                + $"Products.................: \t{ProductName()} \n\t"
                + $"Discount.................: \t{Discount,20:P2} \n\t"
                + $"Value....................: \t{ValueToPay(),20:C2}\n";
        }

        public override decimal ValueToPay()
        {
            decimal valorProductos = 0;
            foreach (var item in Products)
            {
                valorProductos += item.ValueToPay();   
            }
            return valorProductos * (decimal)(1-Discount);
        }
    }
}
