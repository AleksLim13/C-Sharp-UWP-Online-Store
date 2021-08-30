using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaDariosPizza.CodeBehind
{
    abstract class Abstract_Prices
    {
        private double smallPizza;
        private double mediumPizza;
        private double largePizza;

        private double smallDrink;
        private double mediumDrink;
        private double largeDrink;

        private double smallSandwich;
        private double mediumSandwich;
        private double largeSandwich;

        private double smallWings;
        private double mediumWings;
        private double largeWings;

        private double smallFries;
        private double mediumFries;
        private double largeFries;

        private double smallDesert;
        private double mediumDesert;
        private double largeDesert;

        public Abstract_Prices() { }

        public Abstract_Prices(double smallPizza, double mediumPizza, double largePizza, double smallDrink, double mediumDrink, double largeDrink, double smallSandwich, double mediumSandwich, double largeSandwich, double smallWings, double mediumWings, double largeWings, double smallFries, double mediumFries, double largeFries, double smallDesert, double mediumDesert, double largeDesert)
        {
            this.smallPizza = smallPizza;
            this.mediumPizza = mediumPizza;
            this.largePizza = largePizza;
            this.smallDrink = smallDrink;
            this.mediumDrink = mediumDrink;
            this.largeDrink = largeDrink;
            this.smallSandwich = smallSandwich;
            this.mediumSandwich = mediumSandwich;
            this.largeSandwich = largeSandwich;
            this.smallWings = smallWings;
            this.mediumWings = mediumWings;
            this.largeWings = largeWings;
            this.smallFries = smallFries;
            this.mediumFries = mediumFries;
            this.largeFries = largeFries;
            this.smallDesert = smallDesert;
            this.mediumDesert = mediumDesert;
            this.largeDesert = largeDesert;
        }

        public double SmallPizza { get => smallPizza; set => smallPizza = value; }
        public double MediumPizza { get => mediumPizza; set => mediumPizza = value; }
        public double LargePizza { get => largePizza; set => largePizza = value; }
        public double SmallDrink { get => smallDrink; set => smallDrink = value; }
        public double MediumDrink { get => mediumDrink; set => mediumDrink = value; }
        public double LargeDrink { get => largeDrink; set => largeDrink = value; }
        public double SmallSandwich { get => smallSandwich; set => smallSandwich = value; }
        public double MediumSandwich { get => mediumSandwich; set => mediumSandwich = value; }
        public double LargeSandwich { get => largeSandwich; set => largeSandwich = value; }
        public double SmallWings { get => smallWings; set => smallWings = value; }
        public double MediumWings { get => mediumWings; set => mediumWings = value; }
        public double LargeWings { get => largeWings; set => largeWings = value; }
        public double SmallFries { get => smallFries; set => smallFries = value; }
        public double MediumFries { get => mediumFries; set => mediumFries = value; }
        public double LargeFries { get => largeFries; set => largeFries = value; }
        public double SmallDesert { get => smallDesert; set => smallDesert = value; }
        public double MediumDesert { get => mediumDesert; set => mediumDesert = value; }
        public double LargeDesert { get => largeDesert; set => largeDesert = value; }
    }//End CL:*

}//End NS:*
