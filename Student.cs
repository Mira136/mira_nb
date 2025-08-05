using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mira_nb
{
    public class Student
    {
        int rlno;
        string name;

        public Student()//default constructor
        {
            //rlno = 110;
            //name = "AAAA";
            Console.WriteLine("Enter rollnumber:");
            rlno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name of student:");
            name = Console.ReadLine();
        }

        public Student(int r, string n) // parameterised constructor
        {
            rlno = r;
            name = n;
        }

        public Student(Student s)//copy constructor
        {
            rlno = s.rlno;
            name = s.name;
        }

        /*public Student() // static constructor
        { 
            Console.WriteLine("Static constructor is called");
        }*/

        public void showData()
        {
            Console.WriteLine("Roll number is:" + rlno);
            Console.WriteLine("Name is:" + name);
        }
    }

    internal class Class3
    {
        public static void Main(string[] args)
        {
            /* Student s1 = new Student();//constructer is called here
               s1.showData();
               int x = 112;
               string y = "aaaa";
               Student s2 = new Student(110,"ABC");
               s2.showData();
               Student s3 = new Student(x,y);//const is called
               s3.showData();
               Student s4 =  new Student(s2);
               s4.showData(); */

            Student[] s = new Student[2];
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = new Student();
            }
            Console.WriteLine("Student Details are:");
            for (int i = 0; i < s.Length; i++)
            {
                s[i].showData();
            }
        }
    }
}