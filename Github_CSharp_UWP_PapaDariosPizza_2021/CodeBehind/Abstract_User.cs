using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaDariosPizza.CodeBehind
{
    abstract class Abstract_User
    {
        private int id;
        private static int idCount;
        private string name;
        private string userName;
        private string password;
        private string email;

        public Abstract_User() {
            this.id = IdCount;
            IdCount++;
          
        }//End C:*

        public Abstract_User(string name, string userName, string email, string password)
        {

            this.id = Abstract_User.idCount;
            Abstract_User.idCount++;
            Name = name;
            UserName = userName;
            Email = email;
            Password = password;
        }//End C:*

        public string Name { get => name; set => name = value; }
        
        public string UserName { get => userName; set => userName = value; }
        
        public string Email { get => email; set => email = value; }
        
        public string Password { get => password; set => password = value; }
        
        public int Id { get => id; set => id = value; }
        public static int IdCount { get => idCount; set => idCount = value; }

        public abstract string Print();

    }//End CL:*

}//End NS:*
