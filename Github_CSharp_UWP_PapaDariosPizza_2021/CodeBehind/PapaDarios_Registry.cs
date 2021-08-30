using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaDariosPizza.CodeBehind
{
    class PapaDarios_Registry : Abstract_Register
    {
        public PapaDarios_Registry() : base()
        {

        }//End C:*

        public override Abstract_User CreateUser(string name, string userName, string email, string password)
        {
            PapaDarios_User_Customer user = new PapaDarios_User_Customer(name, userName, email, password);
            
            if (RegisterPage.RegisterManager != null && RegisterPage.RegisterManager.Registry != null) {
                RegisterPage.RegisterManager.Registry.Add(user);
            }//End I:*

            return user;

        }//End M:*

        public override string ReadUser(int id) {

            if (RegisterPage.RegisterManager != null && RegisterPage.RegisterManager.Registry != null && RegisterPage.RegisterManager.Registry.Count != 0) {
                
                for (int i = 0; i < RegisterPage.RegisterManager.Registry.Count; i++)
                {
                    if (id == RegisterPage.RegisterManager.Registry[i].Id)
                    {
                        return RegisterPage.RegisterManager.Registry[i].ToString();
                    }//End I:*

                }//End F:*

            }//End I:*

            return null;
        }//End M:*

        public override string ReadUser(Abstract_User user) {
            return "Name:  " + user.Name + "User Name: " + user.UserName + "Email: " + user.Email + "Password: " + user.Password ;
        }//End M:*

        public override void UpdateUserName(int id, string un) {
            for (int i = 0; i < Registry.Count; i++)
            {
                if (id == Registry[i].Id)
                {
                    Registry[i].UserName = un;
                }//End I:*
            }//End F:*
        }//End M:*

        public override void UpdateName(int id, string n) {
            for (int i = 0; i < Registry.Count; i++)
            {
                if (id == Registry[i].Id)
                {
                    Registry[i].Name = n;
                }//End I:*
            }//End F:*
        }//End M:*

        public override void UpdateEmail(int id, string email) {
            for (int i = 0; i < Registry.Count; i++)
            {
                if (id == Registry[i].Id)
                {
                    Registry[i].Email = email;
                }//End I:*
            }//End F:*
        }//End M:*

        public override void UpdatePassword(int id, string password) {
            for (int i = 0; i < Registry.Count; i++)
            {
                if (id == Registry[i].Id)
                {
                    Registry[i].Password= password;
                }//End I:*

            }//End F:*
        }//End M:*

        public override void DeleteUser(int id) {

            List<Abstract_User> uL = new List<Abstract_User>();

            int target = 0;

            for (int i = 0; i < Registry.Count; i++)
            {

                if (id == Registry[i].Id)
                {
                    target = i;
                }//End I:*

            }//End F:*

            for (int i = 0; i < target; i++)
            {
                uL.Add(Registry[i]);
            }//End F:*

            target++;

            for (int i = target; i < Registry.Count; i++)
            {
                uL.Add(Registry[i]);
            }//End F:*

            Registry = uL;

        }//End M:*

    }//End CL:*

}//End NS:*
