using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop4
{
    /*Question 4)   
 a) Create a base class named Employee with method That Work as it prints    "Employee is  working".
 */
    public class Employee
    {
        public virtual void Work()
        {
            Console.WriteLine("Employee is working");
        }
    }
}
