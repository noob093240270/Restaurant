using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson26
{
    public class Waiter : Staff
    {
        public double TotalTipsEarned { get; protected set; } = 0.0;

        public Waiter(string name, double hourlyRate, double totalFineReceived, double totalTipsEarned): base(name,hourlyRate, totalFineReceived)
        {
            TotalTipsEarned = totalTipsEarned;
        }

        public override double CalculateSalary(int hours)
        {
            return HourlyRate * hours + TotalTipsEarned - totalFineReceived;
        }

        public void GetTips(double value)
        {
            TotalTipsEarned += value;
        }

        public override string ToString()
        {
            return $"Name: {Name}, HourlyRate: {HourlyRate}, totalFineReceived: {totalFineReceived}, totalTipsEarned: {TotalTipsEarned}\n";
        }
    }
}
