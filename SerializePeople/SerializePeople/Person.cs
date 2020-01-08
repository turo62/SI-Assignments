using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace SerializePeople
{

    [Serializable]
    public class Person : IDeserializationCallback
    {
        public string Name { get; set; }

        public Genders Gender { get; }

        [NonSerialized]
        public int age;

        public DateTime birthDay;

        public DateTime BirthDay
        {
            get => birthDay;
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Set birthday with past dates!");
                }
                birthDay = value;
            }
        }

        public Person() { }

        public Person(string myName, DateTime birthDay, Genders gender)
        {
            Name = myName;
            BirthDay = birthDay;
            Gender = gender;
            age = (DateTime.Now.Year - BirthDay.Year);
        }

        public override string ToString()
        {
            string stringifyGender = Gender.ToString();
            return "Name: " + Name      + ", birthday: " + BirthDay + ", gender: " + stringifyGender + ",age: " + age;
        }

        public void Serialize(string output)
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(output, FileMode.Create, FileAccess.Write);

                formatter.Serialize(stream, this);
                stream.Close();
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Access to {0} is denied. ", output);
            }            
        }

        public static Person Deserialize(string input)
        {
            Person objnew = new Person();
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(input, FileMode.Open, FileAccess.Read);
            objnew = (Person)formatter.Deserialize(stream);
            stream.Close();

            /*Console.WriteLine(objnew.Name);
            Console.WriteLine(objnew.BirthDay);
            Console.WriteLine(objnew.Gender);
            Console.WriteLine(objnew.age);

            Console.ReadKey();*/

            return objnew;  
        }

        void IDeserializationCallback.OnDeserialization(Object sender)
        {
            age = DateTime.Now.Year - BirthDay.Year;
        }
    }

    public enum Genders
    {
        MALE,
        FEMALE
    }
}
