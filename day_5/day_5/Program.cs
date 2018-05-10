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

            Console.WriteLine("Master, please, tell me what year it is now?");
            int gads1, gads2;
            string ievade1 =Console.ReadLine();
            gads1 = Convert.ToInt16(ievade1);
            Console.WriteLine("Master, please, tell me in what year you were born?");
            string ievade2 = Console.ReadLine();
            gads2 = Convert.ToInt16(ievade2);
            int rezultats = gads1 - gads2;
            Console.WriteLine("That means, my Master is about "+rezultats+" years old.");
            Console.ReadLine();

        }
    }
}
