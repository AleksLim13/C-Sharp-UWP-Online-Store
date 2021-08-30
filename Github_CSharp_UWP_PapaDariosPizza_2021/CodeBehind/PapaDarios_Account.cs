using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaDariosPizza.CodeBehind
{
    class PapaDarios_Account : Abstract_Account
    {
        public PapaDarios_Account()
        {

        }//End C:*

        public PapaDarios_Account(int customerId, List<int> orderIds, bool isSignedin) : base(customerId, orderIds, isSignedin)
        {

        }//End C:*

        public override void ModifyOrder(int orderId)
        {
           
        }//End C:*

        public override string ReadOrder(int orderId)
        {
            throw new NotImplementedException();
        }//End C:*

    }//End CL:*

}//End NS:*
