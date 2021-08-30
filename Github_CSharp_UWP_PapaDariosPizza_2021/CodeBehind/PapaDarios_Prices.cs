using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaDariosPizza.CodeBehind
{
    class PapaDarios_Prices : Abstract_Prices
    {
        public PapaDarios_Prices()
        {
            SmallPizza = 1.0;
            MediumPizza = 2.0;
            LargePizza = 3.0;

            SmallDrink = 1.0;
            MediumDrink = 2.0;
            LargeDrink = 3.0;

            SmallSandwich= 1.0;
            MediumSandwich = 2.0;
            LargeSandwich = 3.0;

            SmallWings= 1.0;
            MediumWings= 2.0;
            LargeWings= 3.0;

            SmallFries= 1.0;
            MediumFries= 2.0;
            LargeFries= 3.0;

            SmallDesert= 1.0;
            MediumDesert= 2.0;
            LargeDesert= 3.0;

        }//End C:*

        public PapaDarios_Prices(double smallPizza, double mediumPizza, double largePizza, double smallDrink, double mediumDrink, double largeDrink, double smallSandwich, double mediumSandwich, double largeSandwich, double smallWings, double mediumWings, double largeWings, double smallFries, double mediumFries, double largeFries, double smallDesert, double mediumDesert, double largeDesert) : base(smallPizza, mediumPizza, largePizza, smallDrink, mediumDrink, largeDrink, smallSandwich, mediumSandwich, largeSandwich, smallWings, mediumWings, largeWings, smallFries, mediumFries, largeFries, smallDesert, mediumDesert, largeDesert)
        {

        }//En C:*

    }//End CL:*

}//End NS:*
