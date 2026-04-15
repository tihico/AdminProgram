using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdminProgram
{
    internal class UserManager
    {
        List<User> _userlist = new List<User>();
        int id = 0;

        public void AddUser(User user)
        {
            // User toegevoegd
            _userlist.Add(user);

        }

        public void print()
        {

            foreach (User user in _userlist)
            {
                // Print elke user.
                user.print();
            }

            if (_userlist.Count == 0)
            {
                Console.WriteLine("Leeg");
            }
        }

        public void UserAdding()
        {
            Boolean validEmail = false;
            Boolean validAge = false;

            Console.WriteLine("Zeg de username");
            string name = Console.ReadLine();

            

            Console.Clear();
            
            string email = "";
            // slight help from AI, it told me a "do-while loop" was a better idea
            // probably because it was the best way to keep re-doing the question and stop when its true
            // otherwise with if it would just go thru it anyway and continue
            do
            {
                Console.WriteLine("Enter email (moet zijn @gmail.com):");
                email = Console.ReadLine();
                if (email.Contains("@gmail.com"))
                {
                    validEmail = true;
                }
                else
                {
                    Console.WriteLine("Incorrecte email! Probeer nog een keer.");
                }
            } while (!validEmail);
            Console.Clear();
            Console.WriteLine("Zeg de password");
            string password = Console.ReadLine();

            Console.Clear();
            int age;
            do
            {
                // Nog een do-while zodat je moet een correcte leeftijd in typen.
                Console.WriteLine("Zeg hoe oud je bent ( 1-200 )");
                int.TryParse(Console.ReadLine(), out age);
                if (age >= 1 && age <= 200)
                { 
                    validAge = true;
                }
                else
                {
                    Console.WriteLine("Incorrect leeftijd!!");
                }
            } while (!validAge);
            Console.Clear();
            Console.WriteLine("Zeg de address");
            string address = Console.ReadLine();
            Console.Clear();


            Console.WriteLine("New user toegevoegd");
            // ID wordt gemaakt hier, een getal 1-1000000000 wordt gegenereerd
            Random rnd = new Random();
            id = id + rnd.Next(1, 1000000000); 
            User user = new User(name, address, email, password, age, id);
            AddUser(user);


        }
        public void UserRemove()
        {

            Console.WriteLine("Enter de ID van de user om de user te verwijderen:");
            int.TryParse(Console.ReadLine(), out int targetId);

            // Zoekt voor de user door de lijst heen
            var userToRemove = _userlist.FirstOrDefault(u => u.ID == targetId);

            for (int i = 0; i < _userlist.Count; i++)
            {
                // als de targetId is een user in de userlist, wordt er naar opgeteld en verwijderd.
                if (targetId == _userlist[i].ID)
                {
                    
                    Console.WriteLine($"Verwijderd", userToRemove);
                    _userlist.Remove(userToRemove);
                }
                else
                {
                    Console.WriteLine("Niet gelukt om te verwijderen");
                }
            }
        }
         public void UserEdit()
        {
            Console.WriteLine("Welke gebruiker will je editen? Typ in de ID");
            int.TryParse(Console.ReadLine(), out int targetId);

           User target = _userlist.Find(u => u.ID == targetId);

            if (target != null)
            {
                /// welke dingen wil je editen? 
                Console.WriteLine("Welke informatie will je editen?");
                Console.WriteLine("1.Naam");
                Console.WriteLine("2.Email");
                Console.WriteLine("3.Leeftijd");
                Console.WriteLine("4.Exit");
                /// 123 voor welke optie inoput je geeft.
                int.TryParse(Console.ReadLine(), out int something);
                if (something == 1) 
                {
                    Console.WriteLine("Typ in wat je de naam wil veranderen naar");
                  string rename = Console.ReadLine();
                   // User _userlist = new User();
                    target.Name = rename;
                    Console.Clear();
                    Console.WriteLine("Naam veranderd");
                }
                
                    
                    
                 if(something == 2)
                    {
                        Boolean validEmail = false;
                    // zeker maken dat je het gmail gaat veranderen met do
                    do
                    {
                        
                        Console.WriteLine("Typ in wat je de email wil veranderen naar");
                        string emailchange = Console.ReadLine();
                 if (emailchange.Contains("@gmail.com"))
                        {
                                target.Email = emailchange;
                                validEmail = true;
                                Console.Clear();
                                Console.WriteLine("Email veranderd");
                            }
                            else
                            {
                                Console.WriteLine("Incorrect email! moet @gmail.com erin hebben");
                            }
                        } while (!validEmail);
                    }
                
                 if (something == 3) 
                {
                    Boolean validAge = false;
                    // zeker maken dat de leeftijd correct is en dat je de leeftijd gaat veranderen
                    do
                    {
                    
                        Console.WriteLine("Typ in wat je de leeftijd wil veranderen naar");
                    int.TryParse(Console.ReadLine(), out int agechange);
                        if (agechange >= 1 && agechange <= 200)
                        {
                            target.Age = agechange;
                            validAge = true;
                            Console.Clear();
                            Console.WriteLine("Leeftijd veranderd");
                        }
                        else
                        {
                            Console.WriteLine("Incorrect leeftijd!! Moet tussen 1-200 zijn.");
                        }
                } while (!validAge);
            }


                else 
                {
                    Console.WriteLine("Uit editing gegaan");
                }
                /// Waar je wil je het naar veranderen? 
                /// input opvangen. 
                /// Dat deel van de user aanpassen. 
                /// user.name = nieuwe input
                /// _userlist[targetid - 1] = target.

            }
        }
        }


    }


