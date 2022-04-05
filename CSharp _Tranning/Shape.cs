   //Abstract class example

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp__Tranning
{
    abstract public class Shape
    {
        abstract public void calcutaleArea();
    }
    public class Circle : Shape
    {
        private int radius;
        private double result, PI = 3.14;

        public Circle(int radius)
        {
            this.radius = radius;
        }
        public override void calcutaleArea()
        {
            result = PI * radius * radius;
        }

        public override string ToString()
        {
            return "Area of Circle is :" + result;
        }



    }
}
