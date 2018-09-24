using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monday___classes_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an animal");
            string animalType = Console.ReadLine();
            Console.Write("Please enter the sound that animal makes");
                string animalSound = Console.ReadLine();

            Animal first = new Animal(animalType, animalSound);

            Console.WriteLine(first.animalSays());
        }
    }

    class Animal
    {
        public string name;
        public string sound;

        public string Name { get { return name; }set { name = value; } }
        public string Sound { get { return sound; }set { sound = value; } }

        public Animal (string _name, string _sound)
        {
            Name = _name;
            Sound = _sound;
        }

        public string animalSays()
        {
            return "The" + Name + " says" + Sound;
        }

    }
}

namespace Task2
{
    class Task2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee's First Name: ");
            string FName = Console.ReadLine();
            Console.WriteLine("Employee's Last Name: ");
            string LName = Console.ReadLine();
            Console.WriteLine("Employee's gross annual salary: ");
            int Salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Employee's Tax Rate: ");
            int TaxRate = int.Parse(Console.ReadLine());

            Employee e1 = new Employee(FName, LName, Salary, TaxRate);
            Console.WriteLine(e1.NetSalary());
        
        }
    }

    class Employee
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public double Salary { get; set; }
        public double TaxRate { get; set; }

        public Employee (string _fname, string _lname, int _salary, int _taxRate)
        {
            FName = _fname;
            LName = _lname;
            Salary = _salary;
            TaxRate = _taxRate;
        }

        public  double NetSalary()
        {
            return Math.Round(Salary*(1-TaxRate),2 );
        }
    }
}
