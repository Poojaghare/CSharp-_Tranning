using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp__Tranning
{
    public delegate int MyDelegate(int a, int b);
    public delegate int MyDel(string name);
    public class Calcutation1
    {
        public int Addition(int a , int b)
        {
            return a + b;
        }
        public int Subtract(int a , int b)
        {
            return a - b;
        }

        public int multiply(int a,int b)
        {
            return a * b;
        }

        }
        public class Test
    {
        public string AcceptName(string name)
        {
            return name.ToUpper();
        }
    }
        
}
