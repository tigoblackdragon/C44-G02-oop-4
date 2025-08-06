using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop4
{
    /*Question 5)  
  a) Create a base class BaseClass with a virtual method DisplayMessage that prints  "Message from BaseClass".

  b) Create a derived class DerivedClass1 that overrides the DisplayMessage method using the override keyword.

  C) Create another derived class DerivedClass2 that hides the DisplayMessage method using the new keyword.

   Then explain the difference between using override and new (using binding behavior)*/

    public class BaseClass
    {
        public virtual void DisplayMessage()
        {
            Console.WriteLine("Message from BaseClass");
        }
    }
}
