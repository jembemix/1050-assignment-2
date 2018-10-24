using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Console.WriteLine("Enter your first name");
            p1.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name");
            p1.LastName = Console.ReadLine();
            Console.WriteLine("Enter your age");
            p1.Age = int.Parse(Console.ReadLine());
            //p1.Spouse = new Person();

            Person.SumOfAllAges = Person.SumOfAllAges + p1.Age;

            p1.Spouse = new Person();

            Console.WriteLine("Enter your spouse's Name");
            p1.Spouse.FirstName=Console.ReadLine();
            p1.Spouse.LastName = p1.LastName;
            Console.WriteLine("Enter your spouse's age?");
            p1.Spouse.Age = int.Parse(Console.ReadLine());
            p1.Spouse.Spouse = p1;

            Person.SumOfAllAges = Person.SumOfAllAges + p1.Spouse.Age;

            //Person 2

            Person p2 = new Person(); 
            Console.WriteLine("Enter your first name");
            p2.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name");
            p2.LastName = Console.ReadLine();
            Console.WriteLine("Enter your age");
            p2.Age = int.Parse(Console.ReadLine());

            Person.SumOfAllAges = Person.SumOfAllAges + p2.Age;

            p2.Spouse = new Person();
            Console.WriteLine("Enter your spouse's Name");
            p2.Spouse.FirstName = Console.ReadLine();
            p2.Spouse.LastName = p2.LastName;
            Console.WriteLine("Enter your spouse's age?");
            p2.Spouse.Age = int.Parse(Console.ReadLine());
            p2.Spouse.Spouse = p2;

            Person.SumOfAllAges = Person.SumOfAllAges + p2.Spouse.Age;

            p1.PrintNameAndAge();

            p2.PrintNameAndAge();

            Console.WriteLine("The average age is "+(Person.SumOfAllAges/4)+".");

            Console.ReadLine();











        }
    }
}
