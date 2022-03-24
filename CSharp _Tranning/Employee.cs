// this keywork and ToString Method using Constructor

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp__Tranning
{
    internal class Employee
    {
        private int empid;
        private string name;
        private double basicsalary;

        public Employee()
        {
               empid = 0;
               name = "";
               basicsalary = 0.0;
        }

        public Employee(int empid, string empname, double basicsalary)
        {
            this.empid = empid;    // this keyword refers to the data member
            this.name = empname;
            this.basicsalary = basicsalary;

        }
        //To string() of base class object
        // is a string representation of an object
        public override string ToString()
        {
            return " Employee id: " + empid + "Employee Name :" + name + " Employee  Salary : " + basicsalary ;
        }


    }
}
