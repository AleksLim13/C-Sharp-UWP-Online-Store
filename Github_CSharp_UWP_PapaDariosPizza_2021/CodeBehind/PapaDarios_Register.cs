using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaDariosPizza.CodeBehind
{
    class PapaDarios_Suggestions : Abstract_Suggestion
    {
        public PapaDarios_Suggestions()
        {

        }//End C:*

        public PapaDarios_Suggestions(string name, string email, string message) : base(name, email, message)
        {

        }//End C:*

        public override string Print()
        {
            return "Name: " + Name + ",\n" +
                   "Email: " + Email + ",\n" + 
                   "Message: " + Message + "\n";
        }//End M:*

        public override string Send()
        {
            return "";
        }//End C:*

    }//End CL:*

}//End NS:*
