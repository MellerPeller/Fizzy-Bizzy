using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzy_Bizzy
{
    internal class Program
    { //Start without debugging
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                string str = "";
                if (i % 3 == 0)
                {
                    str += "Fizzy";
                }
                if (i % 5 == 0)
                {
                    str += "Buzzy";
                }
                if (str.Length == 0)
                {
                    str = i.ToString();
                }
                Console.WriteLine(str);

            }
        }
    }
}
