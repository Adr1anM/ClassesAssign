using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsAssignment
{
    public class Employee : ICloneable
    {
        private string? name;
        private int employeeId;

        public string? Name
        {
            get { return name; }
            set { name = value; }
        }

        public int EmployeeId 
        {
            get { return employeeId; }
            set { employeeId = value; }
        }
      
        public Employee(string name , int id)
        {
            this.name = name;
            this.employeeId =  id;   
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Employee Name = {Name} , ID = {EmployeeId}");
        }

        public virtual void Works()
        {
            Console.WriteLine("The employee is working ");
        }
        public virtual void Works(int time)
        {
            Console.WriteLine($"The employee is working for: {time} yers");
        }


        public virtual object Clone() 
        {
            Employee clonedEmployee =  (Employee)this.MemberwiseClone();

            return clonedEmployee;
        }
    }
}

