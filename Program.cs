//Tip Calculator

// Main
// Welcome
Console.WriteLine("Welcome to the tip calculator!");
Console.WriteLine();
// Prompt the user to enter the bill total
Console.WriteLine("Please enter your bill total: ");
double total = Convert.ToDouble(Console.ReadLine());


//Calling methods to calculate tip and add to total
TipCalculation(total);

// Declare variables
double fifteen;
double eighteen;
double twenty;
double fifteenPer;
double eighteenPer;
double twentyPer;
// Display total with tip
AddTip(fifteenPer, eighteenPer, twentyPer, total);






void TipCalculation(double total)
{
    fifteen = 0.15;
    fifteenPer = total * 0.15;
    Console.WriteLine($"1. {fifteen:p0}: {fifteenPer:C2}");

    eighteen = 0.18;
    eighteenPer = total * 0.18;
    Console.WriteLine($"2. {eighteen:p0}: {eighteenPer:C2}");

    twenty = 0.2;
    twentyPer = total * .20;
    Console.WriteLine($"3. {twenty:p0}: {twentyPer:C2}");

    Console.WriteLine("4. Other amount: ");
    
}


void AddTip(double fifteenPer, double eighteenPer, double twentyPer, double total)
{
    Console.WriteLine("Please select your tip: ");
    int tipSelection = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    switch (tipSelection)
    {
        case 1:
            double grandTotal = total + fifteenPer;
            Console.WriteLine($"Your total with tip is: {grandTotal:C2}");
            break;
        case 2:
            grandTotal = total + eighteenPer;
            Console.WriteLine($"Your total with tip is: {grandTotal:C2}");
            break;
        case 3:
            grandTotal = total + twentyPer;
            Console.WriteLine($"Your total with tip is: {grandTotal:C2}");
            break;
        case 4:
            Console.WriteLine("Please select your tip amount: ");
            double customTip = Convert.ToDouble(Console.ReadLine())/100;
            grandTotal = total + total*customTip;
            Console.WriteLine();
            Console.WriteLine($"Your total with a tip of {customTip:p0} ({total*customTip:C2}) is: {grandTotal:C2}");
            break;
    }
}