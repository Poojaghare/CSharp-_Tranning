//Demo Example of Constrctor


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp__Tranning
{
    internal class Department1
    {
        private int id;
        private string name, location;

        public Department1(int did,string dname,string loc)
        {
            id = did;
            name = dname;
            location = loc;

        }
        public string Getdata()
        {
            return "Dept id " + id + "Dept name " + name + " dept Location " + location;
        }







    }
}
