using mira_nb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mira_nb
{
    public class Employee1()
    { }

    public void showData()
        {
            Console.WriteLine("Employee id is:" + eId);
            Console.WriteLine("Employee name is:" + eName);
            Console.WriteLine("Employee salary is:" + eSalary);
        }

    internal class DemoClass2
    {
        public static void Main(string[] args)
        {
            Employee1 emp = new Employee1();
            emp.showData();
        }
    }
}
