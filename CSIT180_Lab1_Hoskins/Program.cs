/*
*  Kathryn Hoskins
*  CSIT180 Lab1
*
*  Using the length of your lawn, the width of your lawn, and the percentage of nitrogen
*  in your fertilizer to calculate how many pounds of fertilizer you will need to supply 1.0 pounds 
*  of Nitrogen per 1000 square feet to your lawn
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIT180_Lab1_Hoskins
{
    class Program
    {
        static void Main(string[] args)
        {
            const double NITROGEN_PER_FEET = 1000;
            const double PERCENT_TO_DECIMAL = 100;
            double yardLength, yardWidth, percentOfNitrogen, decOfNitrogen, squareFeetInYard, poundOfNitrogenNeeded, poundsOfFertilizerNeeded;
            Console.WriteLine("What is the length of your yard in feet?: ");
            yardLength = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the width of your yard in feet?: ");
            yardWidth = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the percentage of nitrogen in the fertilizer?: ");
            percentOfNitrogen = Convert.ToDouble(Console.ReadLine());


            //part 1: Square footage of your lawn
            squareFeetInYard = yardLength * yardWidth;

            //part2: Divide the number of square feet by 1000 to get the number of pounds of Nitrogen needed
            poundOfNitrogenNeeded = squareFeetInYard / NITROGEN_PER_FEET;

            //part 3: Convert percentOfNitrogen into a decimal by dividing by 100
            decOfNitrogen = percentOfNitrogen / PERCENT_TO_DECIMAL;

            //part 4:  Calculate the number of pounds of fertilizer needed by dividing the number of pounds of 
            //         Nitrogen you need by the percentage of Nitrogen in the fertilizer
            poundsOfFertilizerNeeded = poundOfNitrogenNeeded / decOfNitrogen;

            Console.WriteLine(); //putting a empty line
            Console.WriteLine("You will need {0:F2} pounds of fertilizer for your yard", poundsOfFertilizerNeeded);
            Console.ReadLine();
        }
    }
}
