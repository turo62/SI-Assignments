using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace SerializePeople
{

    [Serializable]
    public class Person
    {
        public string Name { get; set; }

        public DateTime birthDay;

        public Genders Gender { get; }

        public int age;

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
            return "Name: " + Name      + ", gender: " + stringifyGender;
        }
    }

    public enum Genders
    {
        MALE,
        FEMALE
    }
}
