using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaDariosPizza.CodeBehind
{
    class PapaDarios_User_Customer : Abstract_User
    {
        public PapaDarios_User_Customer()
        {

        }//End C:*

        public PapaDarios_User_Customer(string name, string userName, string email, string password) : base(name, userName, email, password)
        {

        }//End C:*

       
        public override string Print()
        {
            return "Id: " + Id + ",\n" +
                   "Name: " + Name + ",\n" +
                   "User Name: " + UserName + ",\n" +
                   "Password: " + Password + ",\n" +
                   "Email:" + Email;
                   
        }//End M:*

    }//End CL:*

}//End NS:*
