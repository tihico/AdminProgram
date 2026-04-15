using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProgram
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Boolean stop = false;

            int something = 0;
            UserManager usermanager = new UserManager();

            while (!stop)
            {

                Console.WriteLine("Voer een nummer in voor welke actie je wil nemen");
                Console.WriteLine("1. Gebruiker maken");
                Console.WriteLine("2. Gebruiker tonen");
                Console.WriteLine("3. Gebruiker verwijderen");
                Console.WriteLine("4. Gebruiker editen");
                Console.WriteLine("5. STOP");

                int.TryParse(Console.ReadLine(), out something);
                Console.Clear();
                if (something == 1)
                {
                    // Begin process van user toevoegen
                    usermanager.UserAdding();
                }
                if (something == 2)
                {
                    // Print alleen alle users
                    usermanager.print();
                }
                if (something == 3)
                {
                    // print de users, geeft je keuze om een user te deleten.
                    usermanager.print();
                    usermanager.UserRemove();

                }
                if (something == 4)
                {
                    // print de users, maakt je in editing gaan
                    usermanager.print();
                    usermanager.UserEdit();
                }
                if (something == 5)
                {
                    // hier stopt de code
                    stop = true;
                }
            }
        }
    }
}
