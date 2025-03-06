using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person
{
    public virtual void GetDetails()
    {
        Console.WriteLine("This is a person.");
    }
}
class Student : Person
{
    public override void GetDetails()
    {
        Console.WriteLine("This is a student.");
    }
}
