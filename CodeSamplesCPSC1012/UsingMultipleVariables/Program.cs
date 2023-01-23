// See https://aka.ms/new-console-template for more information

/*
 * Declare multiple variables that can hold a real number for price, tax, and total
 * This can be done using individual statements or all at one time!
 * Display the price, tax, and total on seperate lines.
 * This can be done using individaul statements or all at one time!
 */

double price;
double tax;
double total;

price = 10.00;
tax = .50;
total = 10.50;

Console.WriteLine($"The price of the item is {price}");
Console.WriteLine($"The tax is {tax}");
Console.WriteLine($"The total is {total}");

// OR

double price2, tax2, total2;

price2 = 20.00;
tax2 = 1.00;
total2 = 21.00;

Console.WriteLine($"\nThe price of the item is {price2}");
Console.WriteLine($"The tax is {tax2}");
Console.WriteLine($"The total is {total2}");

// OR

double price3 = 30.00, tax3 = 1.50, total3 = 31.50;

Console.WriteLine($"\nThe price of the item is {price3} the tax is {tax3} the total is {total3}");

// OR

double price4 = 40.00;
double tax4 = 2.00;
double total4 = 42.00;

Console.WriteLine($"\nThe price of the item is {price4:f2} the tax is {tax4:f2} the total is {total4:f2}");

//OR
Console.WriteLine($"\nThe price of the item is 50.00 the tax is 2.50 the total is 52.50");
