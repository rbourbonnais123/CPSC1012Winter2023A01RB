// See https://aka.ms/new-console-template for more information

/* 
 * Declare a constant for the number of square feet in one acre.
 * When declaring a constant you must also assign the value as part of the declaration.
 */

const double numberOfSquareFeetInOneAcre = 43560;

/*
 * Declare a variable that holds the number of square feet provided by user.
 * Pretend the user enters in the value 87120
 */

double squareFeetUserSupplied;
squareFeetUserSupplied = 87120;

// Declare a variable the holds the calculated number of acres.

double calculatedNumberOfAcres;

// Perform the calculation

calculatedNumberOfAcres = squareFeetUserSupplied / numberOfSquareFeetInOneAcre;

//Print out the answer

Console.WriteLine($"The number of acres for the user supplied value is: {calculatedNumberOfAcres}");

/*
 * Think about:
 *      1. Proper names of variables
 *      2. Why double data type vs int data type
 */

