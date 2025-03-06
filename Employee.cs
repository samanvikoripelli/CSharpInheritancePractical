using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Employee
{
    public virtual double CalculateSalary()
    {
        return 40000;
    }
}
class Manager : Employee
{
    public override double CalculateSalary()
    {
        return base.CalculateSalary() + 10000;
    }
}