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
            // create object of department class
            Department dept = new Department();
            dept.AssignData();
            string str = dept.Getdata();
            Console.WriteLine(str);




            //create object of department1 class

            Department1 dept1 = new Department1(2, "HR", "Mumbai");
            Console.WriteLine(dept1.Getdata());



            // create object student

            Student stud = new Student();  // Default Constrctor

            Console.WriteLine(stud.Getdata());

            Student stud1 = new Student(101, "Siya", "HR", "pune");  // Paramatric constrctor
            Console.WriteLine(stud1.Getdata());
            


            // create object Employee
             
            Employee emp = new Employee( 100, "Riyansh", 25000);
            Console.WriteLine(emp);


            // create object CalculateEmpSalary



            CalculateEmpSalary salary = new CalculateEmpSalary(111, "Avni", 3000);
            salary.CalculateSalary();
            Console.WriteLine(salary);

            

            
            
            

            
        }
    }
}
