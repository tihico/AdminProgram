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
        private string _name { get; }
        private string _address;
        private string _email;
        private string _password;
        private string _phoneNumber;
        private int _age;

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
                    Console.WriteLine("ERROR dit is geen GMAIL zoals een normale persoon");
                }
            }
        }

        public User(string name, string address, string email, string password, int age)
        {
            _name = name;
            _address = address;
            _email = email;
            _password = password;
            _age = age;


        }

    }
}
