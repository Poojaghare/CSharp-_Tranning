// Constructor Example

// Create class Student, add data members, use non paramatric constructor and paramatric constructor & display 
// Student Details


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp__Tranning
{
    internal class Student
    {
       private int id;
        private string name;
       private string departmentName;
        private string location;

        public Student()
        {
            id = 1;
            name = "Tushar";
            departmentName = "Computer Science";
            location = "pune";
        }

        public Student(int sid,string sname,string departName,string Slocation)

        {
            id = sid;
            name = sname;
            departmentName=departName;  
            location = Slocation;

        }

        public string Getdata()
        {
            return "Student id :" + id + " ,  Student Name :"  + name + " ,  Student Department Name :" + departmentName + " ,   Student Location : " + location;   

        }
    }
}
