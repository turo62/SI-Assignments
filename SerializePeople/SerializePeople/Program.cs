using System;

namespace SerializePeople
{
    class Program
    {
        static void Main(string[] args)
        {
            Person newP = new Person("Laci", DateTime.Parse("1962.07.06"), Genders.MALE);
            //Console.WriteLine(newP);
            newP.Serialize(@"actperson.bin");
            Person.Deserialize(@"actperson.bin");
            //Console.WriteLine(Person.Deserialize(@"actperson.bin"));
        }
    }
}
