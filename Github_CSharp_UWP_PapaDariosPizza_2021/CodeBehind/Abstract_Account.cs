using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaDariosPizza.CodeBehind
{
    abstract class Abstract_Account
    {
        private int id;
        private static int idCount; 
        private int customerId;
        private List<int> orderIds;
        private Boolean isSignedin;

        public Abstract_Account()
        {
            Id = IdCount;
            IdCount++;
        }//End C:*

        public Abstract_Account(int customerId, List<int> orderIds, bool isSignedin)
        {
            Id = IdCount;
            IdCount++;
            CustomerId = customerId;
            OrderIds = orderIds;
            IsSignedin = isSignedin;
        }//End C:*

        public int Id { get => id; set => id = value; }
        public static int IdCount { get => idCount; set => idCount = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
        public List<int> OrderIds { get => orderIds; set => orderIds = value; }
        public bool IsSignedin { get => isSignedin; set => isSignedin = value; }

        public abstract string ReadOrder(int orderId);

        public abstract void ModifyOrder(int orderId);

    }//End CL:*

}//End NS:*
