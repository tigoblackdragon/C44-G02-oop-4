using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop4
{
    /*Q1) Write a class named Calculator that contains a method named Add. Overload the Add method to:
 Accept two integers and return their sum.
 Accept three integers and return their sum.
 Accept two doubles and return their sum.
 */
    public class Calculator
    {
        public int Add(int a, int b) => a + b;
        public int Add(int a, int b, int c) => a + b + c;
        public double Add(double a, double b) => a + b;
    }
}
