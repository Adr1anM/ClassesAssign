using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsAssignment
{
    public class Worker : Employee
    {
        private string shift { get; set; }

        public string Shift
        {
            get { return shift; }
            set { shift = value; }
        }

        public Worker(string name, int id, string shift) : base(name, id)
        {
            this.shift = shift;
        }

        public override void Works()
        {
            Console.WriteLine("The worker is in shift");

        }

        public override void Works(int time)
        {
            Console.WriteLine($"The worker is in shift for {time} ours");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Shift: {Shift}");

        }

        public override object Clone()
        {
            return new Worker(Name, EmployeeId, Shift);

        }

    }
}
