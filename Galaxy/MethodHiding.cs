using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy
{
    public class MethodHiding
    {
        public string firstName;
        public string lastName;

        public void PrintFullName()
        {
            Console.WriteLine($"Person name {firstName}", $" {lastName}");
        }
    }

    public class MethodHiding2: MethodHiding
    {
        public new void PrintFullName()
        {
            Console.WriteLine($"Person2 name {firstName}", $" {lastName}");

        }
    }
}
