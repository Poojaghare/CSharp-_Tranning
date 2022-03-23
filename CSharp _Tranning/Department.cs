// Demo Example Declaration of Object and invoking the method//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp__Tranning
{
    internal class Department
    {
        

        
            private int id;
            private string name;
            private string location;

            public void AssignData()
            {

                id = 1;
                name = "Admin";
                location = "pune";
            }
            public string Getdata()
            {
                return "Dept id " + id + "Dept name " + name + " dept Location " + location;
            }







        }
    }


