using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            user u1, u2, u3;
            
            u1 = new user();
            u2 = new user();
            u3=new user();
            
            u1.createuser("ADMIN", "1", "password");
            u2.createuser("GUEST", "0", " ");
            u3.createuser("User","2","password");
            
            int option;
            //string pw;

            bool wannaExit = false;
            int _loginAttempt = 0;

            while (wannaExit == false&&_loginAttempt<3)
            {
                Console.Clear();
                string strMenuString="\n\n1.ADMIN \n2.USER\n3.GUEST \nChoose login option (1 2 or 3) \n";
                Console.Write(strMenuString);
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        _loginAttempt = adminTasks(u1, ref wannaExit,_loginAttempt);
                        break;
                    case 2:
                        _loginAttempt = userTasks(u3, ref wannaExit, _loginAttempt);
                        break;
                    case 3:
                        wannaExit = guestTasks(u2, wannaExit);
                        break;
                    default:
                        wannaExit = wrongOptionTask(wannaExit);
                        break;

                }
                //Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
        }

        private static bool wrongOptionTask(bool wannaExit)
        {
            Console.Write("Option not available");
            Console.WriteLine("Do you want to try again?? Press y to try again and any other key to exit");
            string _choice = Convert.ToString(Console.ReadLine());
            if (!(_choice == "y" || _choice == "Y"))
                wannaExit = true;
            return wannaExit;
        }

        private static bool guestTasks(user u2, bool wannaExit)
        {
            u2.sayHello();
            Console.WriteLine("\n\n1. View posts\n3. Exit");
            wannaExit = true;
            return wannaExit;
        }

        private static int userTasks(user u1, ref bool wannaExit, int _loginAttempt)
        {
            string pw;
            Console.Write("User\n\tPlease enter password:\t");
            pw = Console.ReadLine();
            if (u1.checkpassword(pw))
            {
                u1.sayHello();
                Console.WriteLine("\n\n1. Write new post \n2. View posts\n3. Exit");
                wannaExit = true;
            }
            else
            {
                Console.Write("Sorry, wrong password, login attempt remaining : " + Convert.ToString(2-_loginAttempt));
                _loginAttempt++;
            }
            return _loginAttempt;
        }

        private static int adminTasks(user u1, ref bool wannaExit,int _loginAttempt)
        {
            string pw;
            Console.Write("Admin\n\tplease enter password:\t");
            pw = Console.ReadLine();
            if (u1.checkpassword(pw))
            {
                u1.sayHello();
                Console.WriteLine("\n\n1. Add User \n2. Update User\n3. Remove User\n4. Exit");
                wannaExit = true;
            }
            else
            {
                Console.Write("Sorry, wrong password, login attempt remaining : " + Convert.ToString(2 - _loginAttempt));
                _loginAttempt++;
            }
            return _loginAttempt;
        }

                 
        
    }
}
    

