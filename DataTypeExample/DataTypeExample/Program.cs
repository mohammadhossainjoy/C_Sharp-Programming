using System;

namespace DataTypeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 25;
            double height = 5.8;
            bool isMaried = false;
            char grade = 'A';
            string name = "Joy";


            Console.WriteLine("age:" + age);
            Console.WriteLine("height:" + height);
            Console.WriteLine("Maried:" + isMaried);
            Console.WriteLine("Grade:" + grade);
            Console.WriteLine("Name:" + name);

            age = 26;
            Console.WriteLine("Update age:" + age);


        }
    }
}