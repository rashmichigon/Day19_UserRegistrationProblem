using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_UserRegistrationProblem
{
    internal class RegexClass
    {

        public void name(string name)
        {
            const string NAME = "^[A-Z]{1}[a-z]{2,}$";

            if (Regex.IsMatch(name, NAME))
            {
                Console.WriteLine(name + " is a valid Name");
                return;
            }
            Console.WriteLine(name + " is a invalid Name");
            return;
        }

        private static bool IsMatch(string name, string nAME)
        {
            throw new NotImplementedException();
        }
        public void email(string id)
        {
            const string mailId = "^[a-zA-z0-9]+[.]{0,1}[a-zA-z0-9]+([@]?)+[a-z]{1,15}[.]+(com|co)+((.in)*)$";
            if (RegexClass.IsMatch(id, mailId))
            {
                Console.WriteLine(id + " is a valid Email");
                return;
            }
            Console.WriteLine(id + " is a invalid Email");
            return;
           
        }
        public void MobileNumber(string number)
        {
            const string numberRegex = "^(91 )[6-9]{1}[0-9]{9}$";
            if (Regex.IsMatch(number, numberRegex))
            {
                Console.WriteLine(number + " is a valid Number");
                return;
            }
            Console.WriteLine(number + " is a invalid Number");
            return;
        }

    }
}
