//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AdminProgram
//{
//    internal class UserAdd
//    {
//        int age = 0;
//        int id = 0;
//        Boolean stop = false;
        
//        public void UserAdding()
//        {
            
//            while (!stop) { 
//            List<User> _userlist = new List<User>();

//            Console.WriteLine("Zeg de username");
//            string name = Console.ReadLine();

//            Console.Clear();
//            Console.WriteLine("Zeg de address");
//            string address = Console.ReadLine();

//            Console.Clear();
//            Console.WriteLine("Zeg de email");
//                string email = Console.ReadLine();
               

//            Console.Clear();
//            Console.WriteLine("Zeg de password");
//            string password = Console.ReadLine();
                


//                Console.Clear();
//            Console.WriteLine("Zeg hoe oud");
//            int.TryParse(Console.ReadLine(), out age);

//            Console.WriteLine("New user added");
//                stop = true;
//                id = id + 1;
//                User user = new User(name, address, email, password, age, id);

                




//        }
//        }
//    }
//}
