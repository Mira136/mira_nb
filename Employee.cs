using System;

namespace mira_nb
{
    public class Employee
    {
        int empId;
        string eName;
        double salary;
        void getData()
        {
            empId = 111;
            eName = "Mira";
            salary = 30000.00;
        }
        public void showData()
        {
            Console.WriteLine("Emp id: " + empId);
            Console.WriteLine("Emp Name: " + eName);
            Console.WriteLine("Emp Salary: " +  salary);
        }
        internal class ClassDemo
        {
            public static void Main(string[] args)
            {
                Employee e1 = new Employee();
                e1.getData();
                e1.showData();

                Employee e2 = new Employee();
                e2.getData();
                e2.showData();
            }
        }
    }
}
