using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaDariosPizza.CodeBehind
{
    abstract class Abstract_SignIn
    {
        private int id;
        private static int idCount;
        private static List<Abstract_User> signedInList;
        public static Abstract_User currentUser; 
       

        public Abstract_SignIn()
        {
            Id = IdCount;
            IdCount++;
        }//End C:*

        public List<Abstract_User> SignedInList { get => signedInList; set => signedInList = value; }
        
        public int Id { get => id; set => id = value; }

        public static int IdCount { get => idCount; set => idCount = value; }

        public Abstract_User CurrentUser { get => currentUser; set => currentUser = value; }

        public abstract int SignIn(String userName, string password);

        public abstract void SignOut();

    }//End CL:*

}//End NS:*
