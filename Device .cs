using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Device
{
    public virtual void TurnOn()
    {
        Console.WriteLine("Device is turning on");
    }
}
class Smartphone : Device
{
    public override void TurnOn()
    {
        Console.WriteLine("Smartphone is booting up!");
    }
}
class Tablet : Device
{
    public override void TurnOn()
    {
        Console.WriteLine("Tablet is initializing!");
    }
}