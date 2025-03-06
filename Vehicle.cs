using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Vehicle
{
    public virtual void StartEngine()
    {
        Console.WriteLine("Vehicle engine starting");
    }
}
class Car : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Car engine roaring!");
    }
}
class Motorcycle : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Motorcycle engine revving!");
    }
}
