using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProgram
{
    internal class UserAdd
    {
        int age = 0;
        public void UserAdding() {
            ArrayList _userlist = new ArrayList();
            

            Console.WriteLine("Zeg de username");
            string name = Console.ReadLine();
            _userlist.Add(name);
            Console.Clear();
            Console.WriteLine("Zeg de address");
            string address = Console.ReadLine();
            _userlist.Add(address);
            Console.Clear();
            Console.WriteLine("Zeg de email");
            string email = Console.ReadLine();
            _userlist.Add(email);
            Console.Clear();
            Console.WriteLine("Zeg de password");
            string password = Console.ReadLine();
            _userlist.Add(password);
            Console.Clear();
            Console.WriteLine("Zeg hoe oud");
            int.TryParse(Console.ReadLine(), out age);
            _userlist.Add(age);
            Console.WriteLine("New user added");
            


            //List<string> _userlist = new List<string, string, string, string, string>(name, address, email, password, age);



        }
    }
}
