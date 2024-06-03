using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson26
{
    public abstract class Staff : Employee
    {
        protected double totalFineReceived;
        public double TotalFineReceived
        {
            get { return totalFineReceived; }
            set
            {
                if (value >= 0)
                {
                    totalFineReceived = value;
                }
            }
        }

        protected Staff(string name, double hourlyRate,double totalFineReceived):base(name, hourlyRate)
        {
            TotalFineReceived = totalFineReceived;
        }

        public void GetFine(double value)
        {
            totalFineReceived += value;
        }

        public override string ToString()
        {
            return $"Name: {Name}, HourlyRate: {HourlyRate}, totalFineReceived: {totalFineReceived}\n";
        }
    }
}
