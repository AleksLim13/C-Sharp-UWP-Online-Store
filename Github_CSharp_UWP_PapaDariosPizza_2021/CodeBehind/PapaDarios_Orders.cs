using PapaDariosPizza.CodeBehind;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaDariosPizza
{
    class PapaDarios_Orders : Abstract_Orders
    {
        public PapaDarios_Orders()
        {
        }//End C:*

        public PapaDarios_Orders(Abstract_Product pizza, Abstract_Product drink, Abstract_Product fries, Abstract_Product wings, Abstract_Product sandwich, Abstract_Product desert, List<Abstract_Orders> oLists) : base(pizza, drink, fries, wings, sandwich, desert, oLists)
        {
        }//End C:*

    }//End CL:*
}//End NS:*
