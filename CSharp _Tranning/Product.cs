using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp__Tranning
{
    public class Product
    {
        int prod_code;
        string prod_name;
        float prod_price;

        public Product(int prod_code, string prod_name, float prod_price)
        {
            this.prod_code = prod_code;
            this.prod_name = prod_name;
            this.prod_price = prod_price;
                
        }

        public void Prod_Bill()
        {
            if (prod_price > 5000)
                prod_price *= 0.90f;
        }

        public override string ToString()
        {
            return "Product code: " + prod_code + "product name: " + prod_name + "Product price: " + prod_price ;
        }

    }
}
