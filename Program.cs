class Program
{
    static void Main()
    {
        Animal a = new Dog();
        a.Speak();

        //Person p = new Student();
        //p.GetDetails();

        //Employee emp = new Manager();
        //Console.WriteLine($"Salary: {emp.CalculateSalary()}");

        //Vehicle v1 = new Car();
        //v1.StartEngine();
        //Vehicle v2 = new Motorcycle();
        //v2.StartEngine();

        //SavingsAccount acc = new SavingsAccount();
        //acc.Deposit(1000);

        //Device d1 = new Smartphone();
        //d1.TurnOn();
        //Device d2 = new Tablet();
        //d2.TurnOn();

        Shape rect = new Rectangle(5, 10);
        Console.WriteLine($"Rectangle Area: {rect.CalculateArea()}");
        Shape circle = new Circle(7);
        Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
    }
}