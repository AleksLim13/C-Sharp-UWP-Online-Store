using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaDariosPizza.CodeBehind
{
    class PapaDarios_Fries : Abstract_Product
    {
        public PapaDarios_Fries()
        {

        }//End C:*

        public PapaDarios_Fries(string name, bool small, bool medium, bool large, int amount, double price) : base(name, small, medium, large, amount, price)
        {

        }//End C:*

    }//End CL:*

}//End NS:*
