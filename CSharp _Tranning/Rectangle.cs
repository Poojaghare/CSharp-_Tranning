   //Calcualte area of rectangle using Abstract class//


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp__Tranning
{
    abstract public class Rectangle
    {
        abstract public void CalculateArea1();
    }

    public class AbstractRec : Rectangle
    {
        private int width;
        private int height;

        private double result;

        public AbstractRec(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public override void CalculateArea1()
        {
            result = width * height;
        }

        public override string ToString()
        {
            return "Area of Rectangle : " + result;
        }
    }
}
          

