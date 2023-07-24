using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenMichelleVaca
{
    public abstract class Product:IPay
    {
        public string Description { get; set; }
        public int Id { get; set; }
        public decimal Price { get; set; }
        public float Tax { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }

        public virtual decimal ValueToPay()
        {
            throw new NotImplementedException();
        }
    }
}
