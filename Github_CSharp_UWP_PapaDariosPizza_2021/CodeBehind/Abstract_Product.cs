using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaDariosPizza.CodeBehind
{
    abstract class Abstract_Product
    {
        private string name;
        private bool small;
        private bool medium;
        private bool large;
        int amount;
        private double price;

        public Abstract_Product()
        {
        }//End C:*

        public Abstract_Product(string name, bool small, bool medium, bool large, int amount, double price)
        {
            Name = name;
            Small = small;
            Medium = medium;
            Amount = amount;
            Large = large;
            Price = price;
        }

        public string Name { get => name; set => name = value; }
        public bool Small { get => small; set => small = value; }
        public bool Medium { get => medium; set => medium = value; }
        public bool Large { get => large; set => large = value; }
        public double Price { get => price; set => price = value; }
        public int Amount { get => amount; set => amount = value; }
    }//End CL:*

}//End NS:*
