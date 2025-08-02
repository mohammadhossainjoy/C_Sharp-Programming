using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassandObject
{
    internal class Person
    {
        private string firstName;
        public string middlename;
        public string lastname;
        private int age;

        //Properties use
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if(value >= 18)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Child");
                }
            }
        }

        public string GetFullName()
        {
            string FullName = firstName + " " + middlename + " " + lastname;
            return FullName;
        }

        public void showData()
        {
            Console.WriteLine("Age is :" + age);
        }
    }
}
