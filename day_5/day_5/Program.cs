using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Master, please tell me your name.");
            Console.WriteLine("Type your name now.");
            string vards = Console.ReadLine();
            Console.WriteLine("Now type your surname, please.");
            string uzvards = Console.ReadLine();
            Console.WriteLine("Nice to meet you Master, " + vards + " " + uzvards + ", I'm ready to serve you now!");
            Console.ReadLine();
        }
    }
}
