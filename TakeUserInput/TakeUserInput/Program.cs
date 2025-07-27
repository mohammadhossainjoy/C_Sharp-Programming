using System;
namespace TakeUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please Enter first number: ");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please Enter Second tnumber: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result=num1 + num2; 
            
            Console.WriteLine("Result: "+result);
        }
    }
}