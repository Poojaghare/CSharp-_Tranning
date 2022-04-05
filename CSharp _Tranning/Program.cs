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



            Console.WriteLine("\n ------------------create object Department---------------------------");


            Department1 dept1 = new Department1(2, "HR", "Mumbai");
             Console.WriteLine(dept1.Getdata());



            Console.WriteLine("\n------------------create object Student---------------------------");

            Student student = new Student();
            Console.WriteLine(student);
            
            




            Console.WriteLine("\n------------------create object Employee---------------------------");


            Employee emp = new Employee( 100, "Riyansh", 25000);
            Console.WriteLine(emp); 




            Console.WriteLine("\n------------------create object CalculateEmpSalary---------------------------");


             CalculateEmpSalary salary = new CalculateEmpSalary(111, "Avni", 3000);
            salary.CalculateSalary();
            Console.WriteLine(salary);



            Console.WriteLine("\n------------------create object Calculations---------------------------");


            Calculations cal = new Calculations();
            cal.addition(20, 30);
            Console.WriteLine(cal);

            Calculations cal2 = new Calculations();

            cal2.addition2(20, 30, 40);
            Console.WriteLine(cal2);

            Calculations cal3 = new Calculations();
            cal3.addition3(20, 30.00);
            Console.WriteLine(cal3);


            Console.WriteLine("\n------------------create object Product---------------------------");


            Product p = new Product(100, "ABC", 6000f);
            p.Prod_Bill();
            Console.WriteLine(p);

            Product p2 = new Product(101, "XYZ", 4000f);
            p2.Prod_Bill();
            Console.WriteLine(p2);


            Console.WriteLine("\n------------------create object Delegate---------------------------");


            Calcutation1 c = new Calcutation1();
            MyDelegate mydel = new MyDelegate(c.Addition);

            // added method reference

            mydel += new MyDelegate(c.Subtract);
            mydel += new MyDelegate(c.multiply);

            // remove method ref from invocation list

            mydel -= new MyDelegate(c.Subtract);

            Delegate[]list = mydel.GetInvocationList();
            foreach (Delegate item in list) 
            {
                Console.WriteLine(item.Method);
                Console.WriteLine(item.DynamicInvoke(30,12));
            }

            Console.WriteLine("\n------------------create object Shape-------------------------------");
            Circle circle = new Circle(4);
            circle.calcutaleArea();
            Console.WriteLine(circle);

            Console.WriteLine("\n------------------create object Rectangle---------------------------");

            AbstractRec abc = new AbstractRec(20, 21);
            abc.CalculateArea1();
            Console.WriteLine(abc);


            Console.WriteLine("\n\n============================Interface Class Exapmles====================");
            Console.WriteLine("\n-----------------------------------------");
            Console.WriteLine("-->Explicit Interface");
            ICustomer customer = new Transaction();
            Console.WriteLine(customer.DisplayDetails());

            IOrder oder = new Transaction();
            Console.WriteLine(customer.DisplayDetails());



            Console.WriteLine("\n-----------------Name Exception------------------------");
            User user = new User();
            try
            {
                string name = user.AcceptName("");
                Console.WriteLine("The string name is  : " + name);
            }
            catch (NameException ex)
            {
                Console.WriteLine(ex.Message);
            }



            Console.WriteLine("\n-------------------Age Exception----------------------");
            user user1 = new user();
            try
            {
                int age = user1.AcceptAge(12);
                Console.WriteLine("You age is valid for vote" + age);
            }
            catch (AgeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

       







    }
    }

