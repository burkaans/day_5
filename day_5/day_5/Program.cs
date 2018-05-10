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

            Console.WriteLine("Master, gribi uzzinaat rinka diametru un rinka laukumu, vienkaarshi ievadi rinka radiusu cipariem!");
            double radiuss, diametrs, laukums;
            string ievade3 = Console.ReadLine();
            radiuss = Convert.ToInt16(ievade3);
            diametrs = radiuss * 2;
            laukums = diametrs * 3.14;
            Console.WriteLine("Rinkim ar radiusu " + radiuss +" cm, diametrs ir "+diametrs+" cm, bet laukums " +laukums+ " cm2!");
            Console.ReadLine();

            Console.WriteLine("Ievadiet savu laimigo skaitli");
            string var1;
            var1 = Console.ReadLine();
            string rezultats4 = Funkcija5(var1);
            Console.WriteLine("jusu laimigais skaitlis ir " + rezultats4);
            Console.ReadLine();

            Console.WriteLine("Type this:macos programmet");
            string mainigais2 = Console.ReadLine();

            if (mainigais2 == "macos programmet")
            {
                Console.WriteLine("Good Job!");
            }
            else
            {
                Console.WriteLine("Try again!");
            }
            Console.ReadLine();

            Console.WriteLine("Vai gribat sasveicinaties?");
            string mainigais3 = Console.ReadLine();

            if (mainigais3 == "ja")
            {
                Console.WriteLine("Forshi, ka jus sauc?");
            }
            else if (mainigais3== "ne")
            {
                Console.WriteLine("Zhel gan");
            }
            else
            {
                Console.WriteLine("Rakstiet: ja vai ne");
            }
            Console.ReadLine();
        }
        static string Funkcija5(string vards1)
        {
            string result = vards1;
            return result;

        }
    }
}
