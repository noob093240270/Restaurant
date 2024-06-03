using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson26
{
    public abstract class Employee
    {
        public string Name { get; private set; }
        private double hourlyRate;
        protected double HourlyRate
        {
            get { return hourlyRate; }
            set
            {
                if (value > 0)
                {
                    hourlyRate = value;
                }
            }
        }

        public Employee(string name, double hourlyRate)
        {
            if (name !=  null)
            {
                Name = name;
            }
            this.HourlyRate = hourlyRate;
        }

        public abstract double CalculateSalary(int hours);

        public abstract string ToString();

    }
}
