// See https://aka.ms/new-console-template for more information
using BasicsAssignment;

Console.WriteLine("Hello, World!");


Employee empl1 = new Employee("Igor", 1111);
Employee empl2 = (Employee)empl1.Clone();
empl1.Name = "Victor";
Worker w1 = new Worker("Alex" , 2213 , "Daily");
Worker w2 =  (Worker)w1.Clone();
w1.Shift = "Night";
Manager m1 = new Manager("Aleco",2212,"HR");
m1.AddWorker("Admin",w1);
m1.AddWorker("Devops", w2);

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