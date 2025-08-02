namespace OOPexample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.firstName = "Mohammad";
            person1.middlename = "Hossain";
            person1.lastname = "Joy";

            string fullname=person1.GetFullName();
            Console.WriteLine("FullName is : "+fullname);
            Console.ReadKey();
        }
    }
}