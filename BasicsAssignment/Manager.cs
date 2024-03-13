using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BasicsAssignment
{
    public class Manager : Employee
    {
        private string? department { get; set; }

        public string? Department
        { 
            get { return department; }
            set { department = value; }
        }
        private Dictionary<string, List<Worker>> workersRoles { get; set; }
        public Manager(string name , int id , string department) : base(name,id)
        {
            Department = department;
            workersRoles = new Dictionary<string, List<Worker>>();
        }

        public override void Works()
        {
            Console.WriteLine("The Manager is working ");

        }

        public override void Works(int time)
        {
            Console.WriteLine($"The manager is working here: {time} months");
        }

        public void AddWorker(Worker worker, string role = "Standart")
        {
            if(worker is not null)
            {
                if (!workersRoles.ContainsKey(role))
                {
                    workersRoles[role] = new List<Worker>();
                }

                workersRoles[role].Add(worker);
            }
            else
            {
               throw new NullReferenceException();  
            }
        }

        public void DeleteWorker(string role ,Worker worker)
        {
            if (workersRoles.ContainsKey(role))
            {
                workersRoles[role].Remove(worker);
            }
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Manager name: {Name}  Id: {EmployeeId}");
            Console.WriteLine($"Department: {department}");
            if (IsEmpty())
            {
                DisplayWorkerByRole();
            }

        }

        public bool IsEmpty()
        {
            if(workersRoles.Count <= 0)
            {
                return false;
            
            }
            return true;
        }

        public void DisplayWorkerByRole()
        {
            foreach (var kvp in workersRoles) 
            {
                Console.WriteLine($"Role: {kvp.Key}");

                foreach (var worker in kvp.Value)
                {
                    worker.DisplayInfo();   
                }
            }
        }

        public override object Clone()
        {

            Manager clonedManager = (Manager)this.MemberwiseClone();

            clonedManager.workersRoles = new Dictionary<string, List<Worker>>();

            foreach (var kvp in this.workersRoles)
            {
                List<Worker> clonedlist = new List<Worker>();
                foreach(var worker in kvp.Value)
                {
                    clonedlist.Add((Worker)worker.Clone());
                }

                clonedManager.workersRoles.Add(kvp.Key, clonedlist);    
            }

            return clonedManager;   
        }


    }
}
