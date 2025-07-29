using System;

namespace mira_nb
{
    public class Employee
    {
        int empId;
        string eName;
        double salary;

        public void getData(int empId, string eName, double salary)
        {
            this.empId = empId;
            this.eName = eName;
            this.salary = salary;
        }

        public void showData()
        {
            Console.WriteLine("Emp ID: " + empId);
            Console.WriteLine("Emp Name: " + eName);
            Console.WriteLine("Emp Salary: " + salary);
        }

        public double getSalary()
        {
            return salary;
        }
    }

    internal class ClassDemo
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.getData(111, "Mira", 30000.00);

            Employee e2 = new Employee();
            e2.getData(112, "Mayra", 20000.00);

            Console.WriteLine("Employee with higher salary:");
            if (e1.getSalary() > e2.getSalary())
                e1.showData();
            else
                e2.showData();
        }
    }
}
