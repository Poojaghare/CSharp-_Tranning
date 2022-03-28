//Create class food with food name & price. create list of foods available & display using foreach//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp__Tranning
{
    public class Food
    {
        private string Fname;
        private double Fprice; 

        public Food(string fn, double pr)
        {
            Fname = fn;
            Fprice = pr;
        }
        public override string ToString()
        {
            return ($" {Fname} {Fprice}");
        }
    }
}
