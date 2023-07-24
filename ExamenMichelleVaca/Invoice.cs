using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenMichelleVaca
{
    public class Invoice:IPay
    {
        private List<Product> _products { get; set; }

        public Invoice()
        {
            _products = new List<Product>();
        }
      
        
        public void AddProduct(Product product) { 
            _products.Add(product);
        }

        public void GetInvoice() { 
        }

        public override string ToString()
        {
            string result = "RECEIPT \r\n\r\n------------------------------------------------- \n";
            foreach (var item in _products)
            {
                result += item.ToString();
            }
            result += "\t\t\t\t\t===================== \n"
            + $"TOTAL \t.........................: \t{ValueToPay(),20:C2} \n\t";
            return result;
        }

        public virtual decimal ValueToPay()
        {
            decimal result = 0;
            foreach (var item in _products)
            {
                result += item.ValueToPay();
            }
            return result;
        }
    }
}
