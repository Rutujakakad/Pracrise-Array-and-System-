// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace ArrayProblem
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Speed { get; set; }

        public Car(string model, string make, int year)
        {
            Model = model;
            Make = make;
            Year = year;
            Speed = 0;
        }

        public void Accelerate(double amount)//amount = Increases the car speed in given amount.
        {
            if (amount > 0)
            {
                Speed += amount;
                Console.WriteLine($"Accelerated by {amount} km/h Current speed: {Speed} km/h");
            }
            else
            {
                Console.WriteLine("amount must be in positive");
            }
        }
        public void Decelerate(double amount)
        {
            if (amount > 0)
            {
                Speed -= amount;
                if (Speed < 0) Speed = 0;
                Console.WriteLine($"Decelerated by {amount} km/h Current speed: {Speed} km/h");
            }
            else
            {
                Console.WriteLine("amount must be in positive");
            }
        }
        public void DisplaySpeed()
        {
            Console.WriteLine($"The current speed is {Speed} km/h.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Breeza", "Corolla", 2021);
            car.Accelerate(20);
            car.Decelerate(10);
            car.DisplaySpeed();
            car.Decelerate(15);
        }
    }
}

