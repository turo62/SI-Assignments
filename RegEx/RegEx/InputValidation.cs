using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegEx
{
    class InputValidation
    {
        public static bool IsValidName(string name)
        {
            return Regex.IsMatch(name, @"^([a-zA-Z]+\s*)+$");
        }

        public static bool IsValidPhone(string phone)
        {
            return Regex.IsMatch(phone, @"^(((\d{3})?)|(\d{3}-))?\d{3}-\d{4}$");
        }

        public static bool IsValidMail(string email)
        {
            //return Regex.IsMatch(email, @"^\w+@(\w\.)+[a-z]{2,3}$");
            return Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        }
    }
}
