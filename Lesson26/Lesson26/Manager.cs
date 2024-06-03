using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Lesson26
{
    public class Manager : Employee
    {
        private int efficiencyRate;
        public int EfficiencyRate
        {
            get { return efficiencyRate; } 
            set
            {
                if (Math.Abs(value) <= 100)
                {
                    efficiencyRate = value;
                }
            }
        }



        public Manager(string name, double hourlyRate, int efficiencyRate) : base(name, hourlyRate)
        { 
            this.efficiencyRate = efficiencyRate;
        }

        public void ChangeEfficiencyRate(int value)
        {
            efficiencyRate += value;
        }

        public override double CalculateSalary(int hours)
        {
            return HourlyRate * hours * ((100+efficiencyRate)/100);
        }

        public override string ToString()
        {
            return $"Name: {Name}, HourlyRate: {HourlyRate}, efficiencyRate: {efficiencyRate}\n";
        }

    }
}
