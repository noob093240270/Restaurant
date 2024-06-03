namespace Lesson26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager("Dod", 150, 60);
            Console.WriteLine(manager.ToString());
            manager.ChangeEfficiencyRate(10);
            Console.WriteLine(manager.ToString());
            Console.WriteLine(manager.CalculateSalary(40));

            var cook = new Cook("Tod", 300, 1000, 3);
            Console.WriteLine(cook.ToString());
            cook.SayThanks();
            Console.WriteLine(cook.ToString());
            Console.WriteLine(cook.CalculateSalary(35));

            var waiter = new Waiter("Bob", 160, 3000, 2000);
            Console.WriteLine(waiter.ToString());
            waiter.GetTips(500);
            Console.WriteLine(waiter.ToString());
            Console.WriteLine(waiter.CalculateSalary(60));

            var employees = new EmployeeDatabase(new List<Employee> { manager, cook, waiter });

            Console.WriteLine(employees.GetTotalSalary(40));
            employees.PrintMaxMinSalary(40);


            employees.FineForStaff(400);
            Console.WriteLine(cook.ToString());
            Console.WriteLine(waiter.ToString());

            employees.Print();
        }
    }
}
