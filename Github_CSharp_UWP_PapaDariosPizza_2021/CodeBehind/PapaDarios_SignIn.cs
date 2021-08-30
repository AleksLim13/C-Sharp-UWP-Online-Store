using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaDariosPizza.CodeBehind
{
    class PapaDarios_SignIn : Abstract_SignIn
    {

        public override int SignIn(string userName, string password)
        {
            if (
                RegisterPage.RegisterManager != null && 
                RegisterPage.RegisterManager.Registry.Count != 0 &&
                SignInPage.SignIn != null && 
                SignInPage.SignIn.SignedInList != null
                ) {

                for (int i = 0; i < RegisterPage.RegisterManager.Registry.Count; i++)
                {
                    if (
                            RegisterPage.RegisterManager.Registry[i].UserName == userName &&
                            RegisterPage.RegisterManager.Registry[i].Password == password
                            )
                    {
                        SignInPage.SignIn.SignedInList.Add(RegisterPage.RegisterManager.Registry[i]);
                        SignInPage.SignIn.CurrentUser = RegisterPage.RegisterManager.Registry[i];
                        return 1;
                    }//End F:*

                }//End F:*

            }//End I:*

            return 0;
        }//End M:*

        public override void SignOut()
        {
            List<Abstract_User> uL = new List<Abstract_User>();

            int target = 0;

            for (int i = 0; i < SignedInList.Count; i++)
            {

                if (CurrentUser.Id == SignedInList[i].Id)
                {
                    target = i;
                }//End I:*

            }//End F:*

            for (int i = 0; i < target; i++)
            {
                uL.Add(SignedInList[i]);
            }//End F:*

            target++;

            for (int i = target; i < SignedInList.Count; i++)
            {
                uL.Add(SignedInList[i]);
            }//End F:*

            SignedInList = uL;

            CurrentUser = null; 

        }//End C:*

    }//End CL:*

}//End NS:*
