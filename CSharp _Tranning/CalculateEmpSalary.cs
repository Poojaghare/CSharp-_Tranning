using System;
// Calculate Employee salary program using constrctor and method


using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp__Tranning
{
    public class CalculateEmpSalary
    {
        protected int emp1Id;
        protected string emp1name;
        protected double basicsalary , hra, da,pf , grosssalary;

        public CalculateEmpSalary(int emp1Id, string emp1name, double basicsalary )
        {
            this.emp1Id = emp1Id;
            this.emp1name = emp1name;
            this.basicsalary = basicsalary;
        }
          
          public virtual void CalculateSalary()
        {
            hra = basicsalary * 0.40;
            da = basicsalary * 0.20;
            pf = basicsalary * 0.12;
            grosssalary = (basicsalary + hra + da) - pf;
        }

        public override string ToString()
        {
            return "Emp Id " + emp1Id + "emp name " + emp1name + " Grosssalary " + grosssalary;
        }
    }
}
