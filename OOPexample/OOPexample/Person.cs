using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPexample
{
    internal class Person
    {
        public string firstName;
        public string middlename;
        public string lastname;

        public string GetFullName()
        {
            string FullName = firstName + " " + middlename + " " + lastname;
            return FullName;
        }
    }
}
