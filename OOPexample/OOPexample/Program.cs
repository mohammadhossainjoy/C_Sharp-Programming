namespace ClassandObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Mohammad";
            person1.middlename = "Hossain";
            person1.lastname = "Joy";
            person1.Age = 23;
          
            string fullname=person1.GetFullName();
            Console.WriteLine("FullName is : "+fullname);
            person1.showData();
            Console.ReadKey();
        }
    }
}