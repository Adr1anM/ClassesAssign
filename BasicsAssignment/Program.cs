// See https://aka.ms/new-console-template for more information
using BasicsAssignment;

Console.WriteLine("Hello, World!");


Employee empl1 = new Employee("Igor", 1111);
Employee empl2 = (Employee)empl1.Clone();

empl1.Name = "Victor";
Worker w1 = new Worker(shift:"Daily", id:2213, name: "Alex");
Worker w2 =  (Worker)w1.Clone();

w1.Shift = "Night";
Manager m1 = new Manager("Aleco",2212,"HR");
m1.AddWorker(w1, "Admin");
m1.AddWorker(w2);


Worker w3 = new Worker("Marcus", 3333);
Employee worker = w3 as Employee;
worker.DisplayInfo();

Worker w4 = empl1 as Worker;

if(w4 is null)
{
    Console.WriteLine("Conwersion did not pass");
}
else
{
    w4.DisplayInfo();
}

Manager m2 = (Manager)m1.Clone();

Employee[] emplList = [empl1, empl2];

Employees finalResult = new Employees(emplList);

foreach(Employee empl in finalResult)
{
    empl.DisplayInfo();
}

//empl1.DisplayInfo();
//empl2.DisplayInfo();
//w1.DisplayInfo();
//w2.DisplayInfo();
//m1.DisplayInfo();
//m2.DisplayInfo();