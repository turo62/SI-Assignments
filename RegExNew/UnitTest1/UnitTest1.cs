using Microsoft.VisualStudio.TestTools.UnitTesting;
using regular_expressions;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        readonly string name1 = "The Longest Name Test";
        readonly string name2 = "Name 123";
        readonly string name3 = "";
        readonly string email1 = "mine@hot.hu";
        readonly string email2 = "minehot.hu";
        readonly string email3 = "mine@hot";
        readonly string email4 = "mine@@hot.hu";
        readonly string phone1 = "123-456-0789";
        readonly string phone2 = "1234560789";
        readonly string phone3 = "a23-456-0789";                 
        
        [TestMethod]
        public void TestLongName()
        {            
            Assert.IsTrue(InputChecker.IsValidName(name1));
        }

        [TestMethod]
        public void TestNameWithNumber()
        {            
            Assert.IsFalse(InputChecker.IsValidName(name2));
        }

        [TestMethod]
        public void TestEmptyName()
        {            
            Assert.IsFalse(InputChecker.IsValidName(name3));
        }

        [TestMethod]
        public void TestRightEmail()
        {            
            Assert.IsTrue(InputChecker.IsValidMail(email1));
        }

        [TestMethod]
        public void TestMissingAtSign()
        {
            Assert.IsFalse(InputChecker.IsValidMail(email2));
        }

        [TestMethod]
        public void TestMissingEndOfAddress()
        {
            Assert.IsFalse(InputChecker.IsValidMail(email3));
        }

        [TestMethod]
        public void TestDoubleAtSign()
        {            
            Assert.IsFalse(InputChecker.IsValidMail(email4));
        }

        [TestMethod]
        public void TestRightPhone()
        {
            Assert.IsTrue(InputChecker.IsValidPhone(phone1));
        }

        [TestMethod]
        public void TestMissingSplitPhone()
        {
            Assert.IsFalse(InputChecker.IsValidPhone(phone2));
        }

        [TestMethod]
        public void TestLetterInPhone()
        {
            Assert.IsFalse(InputChecker.IsValidPhone(phone3));
        }
    }
}
