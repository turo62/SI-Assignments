using Microsoft.VisualStudio.TestTools.UnitTesting;
using SerializePeople;
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        readonly Person testP1 = new Person("Zoli", DateTime.Parse("1962.07.06"), Genders.MALE);
        [TestMethod]
        public void TestInstanceCreation()
        {
            

            Assert.IsTrue(testP1.Name == "Zoli");
            Assert.IsTrue(testP1.BirthDay == DateTime.Parse("1962.07.06."));
            Assert.IsTrue(testP1.Gender == Genders.MALE);
            Assert.IsTrue(testP1.age == 58);
        }

        [TestMethod]
        public void TestToStringMethod()
        {
            Assert.IsTrue(Regex.IsMatch(testP1.ToString(), @"Name: Laci, gender: MALE"));
        }

        [TestMethod]
        public void TestSerializeMethod()
        {
            testP1.Serialize(@"testSer.bin");
            Assert.IsTrue(File.Exists(@"testSer.bin"));

            File.Delete(@"testSer.bin");
        }

        [TestMethod]
        public void TestDeserializeMethod()
        {
            testP1.Serialize(@"testSer2.bin");
            Person deserializedP = Person.Deserialize(@"testSer2.bin");
            Assert.IsTrue(deserializedP.Name == testP1.Name);

            File.Delete(@"testSer2.bin");
        }
    }
}
