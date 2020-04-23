using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinirechnerTFO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main

            Console.WriteLine("Minirechner");

<<<<<<< HEAD
            Console.WriteLine();

            Console.Write("Geben Sie eine Zahl ein: ");
            int Zahl1 = Convert.ToInt32(Console.ReadLine());
=======
            Addieren(Zahl1, Zahl2);
>>>>>>> Addition

            Console.Write("Geben Sie eine weitere Zahl ein: ");
            int Zahl2 = Convert.ToInt32(Console.ReadLine());


            Console.ReadKey(); 


        } // Ende des Programmes

        public static int Addieren(int Zahl1, int Zahl2)
        {
            int Ergebnis = Zahl1 + Zahl2;

            Console.WriteLine(Ergebnis);


        } // Addieren





    }
}
