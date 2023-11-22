using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartPhone phone=new SmartPhone("Vivo y91",9000.50);
            phone.Connect();
            phone.Charge(60);            
            phone.Print();
            Laptop lap=new Laptop("Dell",52000.45);
            lap.Connect();
            lap.Charge(45);            
            lap.Print();
            Console.ReadKey();
        }
    }
}
