using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp__Tranning
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Department dept = new Department();
            dept.AssignData();
            string str = dept.Getdata();
            Console.WriteLine(str);
            
            
        }
    }
}
