using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class User
    {

        public static List<string> L = new List<string>();

        public static string Firstname = "^[A-Z]{1}[a-z]{2}$";
        public static void ForFirstName()
        {
            Console.WriteLine("Rule for First Name:-\n1)only 3 character allowed.\n2)Only First char should capital");
            Console.WriteLine("\nEnter first name");
            string Nm = Console.ReadLine();
            L.Add(Nm);
            Regex match = new Regex(Firstname);
            List<string> otherList = L.Select(str => match.Match(str).Value).ToList();
            foreach (string str in otherList)
            {
                if (str.Length > 0)
                {
                    Console.WriteLine("{0} is a valid name.\n", Nm);
                }
                else
                {
                    Console.WriteLine("{0} is  Not valid name.\n", Nm);
                }
            }

        }
    }
}
