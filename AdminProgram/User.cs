using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProgram
{
    internal class User
    {
        //private string _name;
        public string Name { get; set; }
        public string Address { get; set; }
        private string _email;
      
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }

        public int ID = 0;
        

        public string Email
        {
            get { return _email; }
            set
            {
                if (value.Contains("@gmail.com"))
                {
                    
                    _email = value;
                }
                else
                {
                    // Dit code maakt zeker dat @gmail.com in de email zit
                    Console.WriteLine("ERROR dit is geen @gmail.com email!");
                }
            }
        }
        

        public User(string name, string address, string email, string password, int age, int id)
        {
            Name = name;
            Address = address;
            Email = email;
            Password = password;
            Age = age;
            ID = id;


        }
       public void print()
        {
            // User uitgeprint
            Console.WriteLine($"Name: " + Name + " Email: " + Email + " Leeftijd: " + Age + " ID:" + ID); 
        }
    }
}
