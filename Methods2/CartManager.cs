using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class CartManager
    {
        public void Add(Product product) 
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + product.Name);
        }

        public void Add2(string Name, double Price, string Description, int unitInStock)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + Name);
        }
    }
}
