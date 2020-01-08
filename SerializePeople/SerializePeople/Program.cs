using System;

namespace SerializePeople
{
    class Program
    {
        static void Main(string[] args)
        {
            Person newP = new Person("Laci", DateTime.Parse("1962.07.06"), Person.Genders.MALE);
            Console.WriteLine(newP);
        }
    }
}
