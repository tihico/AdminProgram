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
            int something = 0;

            Console.WriteLine("Voer een nummer in voor welke actie je wil nemen");
            Console.WriteLine("1. Gebruiker maken");
            Console.WriteLine("2. Gebruiker tonen");
            Console.WriteLine("3. Gebruiker verwijderen");

            int.TryParse(Console.ReadLine(), out something);
            Console.Clear();
            if (something == 1)
            {
               
                Console.WriteLine("hoi");
                UserAdd opdracht = new UserAdd();
                opdracht.UserAdding();
            }
            if (something == 2)
            {
                //Opdracht9 opdracht = new Opdracht9();
                //opdracht.Start();
                //Console.WriteLine("hoi 2");
                //foreach (User u in _userlist)
                //{

                //    Console.WriteLine(u.name);
                //}
            }
            if (something == 3)
            {
                //UserRemove remove = new UserRemove();
                //remove.Start();
                //Console.WriteLine("im Going to kill you");
            }
;
        }
    }
}
