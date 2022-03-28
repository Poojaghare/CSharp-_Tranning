using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp__Tranning
{
    internal class Program
    {
        static void Main(string[] args)  // entry point of program

        {
            



            //create object of department1 class

           // Department1 dept1 = new Department1(2, "HR", "Mumbai");
           // Console.WriteLine(dept1.Getdata());



            // create object student

            //Student stu = new Student();

            


            // create object Employee
             
            //Employee emp = new Employee( 100, "Riyansh", 25000);
            //Console.WriteLine(emp); 


            // create object CalculateEmpSalary



           // CalculateEmpSalary salary = new CalculateEmpSalary(111, "Avni", 3000);
            //salary.CalculateSalary();
            //Console.WriteLine(salary);//


            //create object calculations

            Calculations cal = new Calculations();
            cal.addition(20, 30);
            Console.WriteLine(cal);

            Calculations cal2 = new Calculations();

            cal2.addition2(20, 30 , 40);
            Console.WriteLine(cal2);

            Calculations cal3 = new Calculations();
            cal3.addition3(20, 30.00);
            Console.WriteLine(cal3 );


            //Create object Product

            Product p = new Product(100, "ABC", 6000f);
            p.Prod_Bill();
            Console.WriteLine(p);

            Product p2 = new Product(101,"XYZ",4000f);
            p2.Prod_Bill();
            Console.WriteLine(p2);


             

            
             

            

            
            
            

            
        }
    }
}
