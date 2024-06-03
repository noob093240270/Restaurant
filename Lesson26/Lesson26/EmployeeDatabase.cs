using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson26
{
    internal class EmployeeDatabase
    {
        public List<Employee> ListOfEmployees { get; private set; } = new List<Employee>();

        public EmployeeDatabase(List<Employee> employees)
        {
            ListOfEmployees = employees;
        }

        public double GetTotalSalary(int hours)
        {
            var res = 0.0;
            foreach (var employee in ListOfEmployees)
            {
                res += employee.CalculateSalary(hours);
            }
            return res;
        }

        public void PrintMaxMinSalary(int hours)
        {
            var mx = 0.0;
            var mxName = "";
            var mn = double.MaxValue;
            var mnName = "";
            foreach (var employee in ListOfEmployees)
            {
                if (mx < employee.CalculateSalary(hours))
                {
                    mx = employee.CalculateSalary(hours);
                    mxName = employee.Name;

                }
                if (mn > employee.CalculateSalary(hours))
                {
                    mn = employee.CalculateSalary(hours);
                    mnName = employee.Name;
                }
                
            }
            Console.WriteLine(mxName);
            Console.WriteLine(mnName);
        }

        public void FineForStaff(double fine)
        {
            foreach (var item in ListOfEmployees)
            {
                if (item is Staff)
                {
                    
                    (item as Staff).TotalFineReceived += fine;
                }
            }
        }

        public void Print()
        {
            foreach (var item in ListOfEmployees)
            {
                switch (item)
                {
                    case Manager s:
                        Console.WriteLine($"{s.Name}, {s.EfficiencyRate}"); break;
                    case Cook s:
                        Console.WriteLine($"{s.Name}, {s.TotalFineReceived}, {s.Thanks}"); break;
                    case Waiter s:
                        Console.WriteLine($"{s.Name}, {s.TotalTipsEarned}, {s.TotalFineReceived}"); break;
                }
                
            }
        }

    }
}
