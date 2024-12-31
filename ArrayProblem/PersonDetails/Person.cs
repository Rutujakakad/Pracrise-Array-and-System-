// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace ArrayProblem
{
    class Person
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }

        public Person(string name, string age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name = {Name}");
            Console.WriteLine($"Age = {Age}");
            Console.WriteLine($"Gender = {Gender}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person obj = new Person("Rahul", "30", "Male");
            obj.DisplayInfo();
        }
    }
        

        
    

      

        
}

