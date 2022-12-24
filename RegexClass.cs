using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19_UserRegistrationProblem
{
    internal class RegexClass
    {

        public void name(string name)
        {
            const string NAME = "^[A-Z]{1}[a-z]{2,}$";

            if (RegexClass.IsMatch(name, NAME))
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
    }
}
