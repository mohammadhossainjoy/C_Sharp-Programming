using System;

namespace Variable
{
    class Program
    {
        static void Main(String[] args)
        {
            string university = "North South University";
            int cseStudent = 5000;
            int eeestudent = 3500;
            double cgpa = 3.20;
            bool isStudent = true;
            char letter= 'A';

            int eceTotalStudent = cseStudent + eeestudent;
            Console.WriteLine(university);
            Console.WriteLine("Total Student: "+ eceTotalStudent);
            Console.WriteLine("Cgpa: "+cgpa);
            Console.WriteLine("isStudent: " + isStudent);
            Console.WriteLine("Letter: "+letter);
      
            Console.ReadKey();
        }
    }
}

