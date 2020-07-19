/*Programmer: Austin Parker
 * Date: Jan. 14th, 2020
 Purpose: This program is used to calculate and 
 display the pricing of retail items.
 */

using System;
using static System.Console;
namespace Retail_Price
{
    class RetailPricing
    {
        static void Main()

        {
            //Declare values for item name, original price, and discount amount.
            string unitName = "Open Collar Running Shirt";
            double retailPrice = 41.00;
            double discount = 0.15;

            /*Below is how you would hypothetically increase or decrease the discount like the question 
             * asked in Chapter 2 of our book. You would change the discount value above all the code 
             * that uses the variable so all "discount" instances in the program are affected by new values. 
            --- discount = .20; ---
            --- discount = .10; ---
            */

            //Calculates discount from original price.
            double retailSale = retailPrice - (retailPrice * discount);

            //totalSalePrice is the result of retailSale calculation to get final price of item.
            double totalSalePrice = retailSale;

            //Displays overall information to console. I created multiple lines for readability.
            Write("Sale Item: {0}\n" +
               "    Original Retail Price: $ {1:F}\n" +
               "    Markdown Price with 15% off: $ {2:F}\n",
               unitName, retailPrice, totalSalePrice);

            //This reassigns new values into the previously declared variables and calculations.
            unitName = "Razorback T-Shirt";
            retailPrice = 36.00;
            retailSale = retailPrice - (retailPrice * discount);
            totalSalePrice = retailSale;

            //Displays updated overall information to console.
            Write("\nSale Item: {0}\n" +
               "    Original Retail Price: $ {1:F}\n" +
               "    Markdown Price with 15% off: $ {2:F}\n",
               unitName, retailPrice, totalSalePrice);

            //Thanks customer for using program.
            WriteLine("\nThanks for using Retail Pricing, please select any key to close the application.");

            ReadKey();

        }
    }
}
