using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp__Tranning
{
    public class ArrayEx
    {
        static void Main(String[]args)
        {
            // Index of array start from 0

            int[] weekdays = new int[7] {1,2, 3, 4, 5, 6, 7};
            int[] list1 = new int[7];

            String[] branch_List = { " IT" , "Civil","Mechanical","HR"};

            Array.Sort(weekdays);
            Console.WriteLine("Week days after sorting");

            for (int i = 0; i < weekdays.Length; i++)
            {
                Console.WriteLine(weekdays[i]);
            }

            Array.Reverse(weekdays);
            Console.WriteLine("Reverse array using reverse method");

            for(int i = 0; i < weekdays.Length; i++)
            {
                Console.WriteLine(weekdays[i]);
            }
            Console.WriteLine("=============================================================");

            Array.Copy(weekdays, list1,7);
            Console.WriteLine("Coppy array");
            for( int i = 0; i < list1.Length; i++)
            {
                Console.WriteLine( list1[i]);
            }

            Console.WriteLine("===============================================================");

            for(int i =0; i < branch_List.Length; i++)
            {
                Console.WriteLine( branch_List[i] );
            }
            Console.WriteLine("==============================================================");

            Array.Clear(weekdays, 3, 4);
            Console.WriteLine( "clear data");
            for( int i = 0; i < weekdays.Length; i++)
            {
                Console.WriteLine( weekdays[i]);
            }
            
    

                 
        }
    }
}
