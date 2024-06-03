using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson26
{
    public class Cook : Staff
    {
        public int Thanks {  get; protected set; } = 0;
        public Cook (string name, double hourlyRate,double totalFineReceived, int Thanks):base(name, hourlyRate, totalFineReceived)
        {
            this.Thanks = Thanks;
        }

        public override double CalculateSalary(int hours)
        {
            return HourlyRate * hours + Thanks*500 - totalFineReceived;
        }

        public void SayThanks()
        {
            Thanks++;
        }

        public override string ToString()
        {
            return $"Name: {Name}, HourlyRate: {HourlyRate}, totalFineReceived: {totalFineReceived}, Thanks: {Thanks}\n";
        }

    }
}
