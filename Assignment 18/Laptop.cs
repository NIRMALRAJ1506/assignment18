using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_18
{
    public class Laptop : IConnectable, IRechargeable, IDisplayable
    {
        string name;
        double price;
        bool Connectable;
        string display;
        int charge;

        public Laptop(string name,double price)
        {
            this.name = name;
            this.price = price;
        }
        public void Charge(int minutes)
        {
            charge += minutes;
            Console.WriteLine("The Device will be charged in: " + charge+" minutes"); 
        }

        public bool Connect()
        {
            Console.WriteLine("Is the Device Connectable?");
            Connectable=bool.Parse(Console.ReadLine());
            
            return Connectable;
        }

        public string Display()
        {
            Console.WriteLine("Enter the Display Info of the Device");
            display = Console.ReadLine();
            Console.WriteLine("Display Info of the Device: "+display);
            return display;
        }

        public string Name { get; set; }
        public double Price { get; set; }

        public void Print()
        {
            Console.WriteLine($"Laptop Details:\nName: {name}\nPrice: {price}\nConnected: {Connectable}\nBattery Level: {charge}%\nDisplay: {Display()}\n");
        }
    }
}
