using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jesper
{
    internal class Program
    { 
        private static int stamina = 36;
        enum Status { Trött, Utvilad, Andfådd, Död, Glad };
        static void Main(string[] args)
        {
            string message = "Hello cool person";
            string namn = "Viera-Rika Otake";
            string betyg = "C";
            int ålder = 17;
            Console.WriteLine(" Hej jag heter " + namn + " och är " + ålder + " år " + ", mitt snitt betyg i 1an va " + betyg );
         Console.WriteLine("jag kan gå stairmaster i " + stamina + " minuter.");
            string märke = "Lexus";
            string bil = "ES300, LS, UX 300h";
            Console.WriteLine("Vi har bara " + märke + " och det här är några av våra modeller " + bil);
            Status currentstate = Status.Trött;
            Console.ReadKey();

            int age = 18;
            if (age >= 21) { }



        }
}
}
