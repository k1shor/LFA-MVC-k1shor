using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class user
    {
        string username;
string usertype;	//1 for admin or 0 for guest
string password;	

public void createuser(string u_name, string u_type, string pword)
{
this.username=u_name;
this.usertype=u_type;
this.password=pword;	
}


public void sayHello()
{
Console.Write("\nWelcome "+this.username);
}

public bool checkpassword(string pw)
{
if(this.password==pw)
return true;
else
return false;
}

    }
}
