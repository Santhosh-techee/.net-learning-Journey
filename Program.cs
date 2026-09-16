/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_object
{
    class Car
    {
        public int Mileage;
        public string Brand;
        public string Color;
        public Car()
        {
            Brand = "hyundai";
            Color = "white";
            Mileage = 20;
        }
        public void display()
        {
            Console.WriteLine("CarBrand=" + Brand);
            Console.WriteLine("CarColor=" + Color);
            Console.WriteLine("Mileage=" + Mileage);
        }

    }
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CarDetails");
            Car car1 = new Car();
            car1.display();

        }
    }
}*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    class student
    {
        string name;
        int age;

        public student(string n, int a)
        {

            name = n;
            age = a;
        }
        public void display()
        {
            Console.WriteLine("name:" + name);
            Console.WriteLine("age:" + age);

        }
        static void Main(string[] args)
        {
            student s1 = new student("vinoth", 20);
            s1.display();
        }
    }
}