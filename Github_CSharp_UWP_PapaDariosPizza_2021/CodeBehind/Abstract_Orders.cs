using PapaDariosPizza.CodeBehind;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaDariosPizza
{
    abstract class Abstract_Orders
    {
        private int id;
        private static int idCount;
        private Abstract_Product pizza;
        private Abstract_Product drink;
        private Abstract_Product fries;
        private Abstract_Product wings;
        private Abstract_Product sandwich;
        private Abstract_Product desert;
        private List<Abstract_Product> prodList;
        private static List<Abstract_Orders> oLists;


        public Abstract_Orders(Abstract_Product pizza, Abstract_Product drink, Abstract_Product fries, Abstract_Product wings, Abstract_Product sandwich, Abstract_Product desert, List<Abstract_Orders> oLists)
        {
            Id = idCount;
            idCount++;
            Pizza = pizza;
            Drink = drink;
            Fries = fries;
            Wings = wings;
            Sandwich = sandwich;
            Desert = desert;
            oLists = new List<Abstract_Orders>();
        }//End C:*

        public Abstract_Orders()
        {
            Id = idCount;
            IdCount++;
            oLists = new List<Abstract_Orders>();
        }//End C:*

        internal Abstract_Product Pizza { get => pizza; set => pizza = value; }
        internal Abstract_Product Drink { get => drink; set => drink = value; }
        internal Abstract_Product Fries { get => fries; set => fries = value; }
        internal Abstract_Product Wings { get => wings; set => wings = value; }
        internal Abstract_Product Sandwich { get => sandwich; set => sandwich = value; }
        internal Abstract_Product Desert { get => desert; set => desert = value; }
        public int Id { get => id; set => id = value; }
        public static int IdCount { get => idCount; set => idCount = value; }
        internal List<Abstract_Product> ProdList { get => prodList; set => prodList = value; }
        internal static List<Abstract_Orders> OLists { get => oLists; set => oLists = value; }
    }//End CL:*
}//End NS:*
