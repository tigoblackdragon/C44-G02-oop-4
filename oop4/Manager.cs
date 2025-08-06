using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop4
{

    public class Manager : Employee
    {
        public override void Work()
        {
            base.Work(); // Calls Employee's Work
            Console.WriteLine("Manager is managing");
        }
    }
}
