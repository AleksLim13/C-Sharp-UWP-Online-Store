using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaDariosPizza.CodeBehind
{
    abstract class Abstract_Register
    {
        private int id;
        private static int idCount;
        private static List<Abstract_User> registry;

        public int Id { get => id; set => id = value; }
        
        public static int IdCount { get => idCount; set => idCount = value; }

        public List<Abstract_User> Registry { get => registry; set => registry = value; }

        public Abstract_Register()
        {
            Id = IdCount;
            IdCount++;
        }//End C:*

        public abstract Abstract_User CreateUser(string name, string userName, string email, string password);
        
        public abstract string ReadUser(int id);
        
        public abstract string ReadUser(Abstract_User user);

        public abstract void UpdateUserName(int id, string un);
        
        public abstract void UpdateName(int id, string n);
        
        public abstract void UpdateEmail(int id, string email);

        public abstract void UpdatePassword(int id, string password);

        public abstract void DeleteUser(int id);

    }//End CL:*

}//End NS:*
