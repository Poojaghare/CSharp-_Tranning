using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp__Tranning
{
    public class SalesManager : CalculateEmpSalary
    {
        public double foodallowance, travlallow, commsion;

        public SalesManager() : base()  // it will call base class ctor
        { foodallowance = 0.0;
            travlallow = 0.0; commsion = 0.0;

        }

        public SalesManager(int id ,string nm , double fa, double ta ,double cm):base(id,nm,bs)
        {
            foodallowance = fa;
            travlallow = ta;
            commsion = cm;

        }

        public override void CalculateSalary()
        {
            hra = basicsalary * 0.40;
            da = basicsalary * 0.20;
            pf = basicsalary * 0.12;
            foodallowance = basicsalary * 0.15;
            travlallow = basicsalary * 0.20;
            grosssalary = (basicsalary + hra + da + foodallowance + travlallow + commsion) - pf;
        }

        public override string ToString()
        {
            return "Emp Id " + emp1Id + "emp name " + emp1name + " Grosssalary " + grosssalary;
        }  

    }

}

       