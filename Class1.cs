using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2._3._2
{
    internal class Class1
    {
        // Method for Calculating different percentage of tips, use C2 for currency formatting
        void TipCalculation(double total)
        {
            double fifteenPer = total * 0.15;
            Console.WriteLine($"Fifteen percent: {fifteenPer}");

            double eighteenPer = total * 0.18;
            Console.WriteLine($"Eighteen percent: {eighteenPer}");

            double twentyPer = total * .20;
            Console.WriteLine($"Twenty percent: {twentyPer}");
        }
    }
}
