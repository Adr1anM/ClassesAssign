using BasicsAssignment;
using System.Collections;

public class Employees : IEnumerable<Employee>
{
    private Employee[] employees;

    public Employees(Employee[] list)
    {
        employees = list ?? throw new ArgumentNullException(nameof(list));
    }

    public IEnumerator<Employee> GetEnumerator()
    {
        foreach (var employee in employees)
        {
            Console.WriteLine("<<--");
            yield return employee;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator(); 
    }
}
