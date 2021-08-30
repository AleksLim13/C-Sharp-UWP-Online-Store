using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaDariosPizza.CodeBehind
{
    abstract class Abstract_Suggestion
    {
        private string name;
        private string email;
        private string message;

        public Abstract_Suggestion(string name, string email, string message)
        {
            Name = name;
            Email = email;
            Message = message;
        }//End C:*

        public Abstract_Suggestion()
        {

        }//End C:*

        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Message { get => message; set => message = value; }

        public abstract string Send();

        public abstract string Print();

    }//End CL:*

}//End NS:*
