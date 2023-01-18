// See https://aka.ms/new-console-template for more information

/*
 * Declare an Integer variable and assign the value 5 to it.
 * Using two statements Write and WriteLine produce the following output: The integer variable contains the value: 5
 * Note: your code can be 3 or 4 statements.
 */

int variableForIntegerNumber;
variableForIntegerNumber = 5;

Console.Write("The integer variable contains the value: ");
Console.WriteLine(variableForIntegerNumber);

/*
 * Doing the above in one line would look like:
 * Console.WriteLine("The integer variable contains the value: " + variableForIntegerNumber);
 * Or
 * Console.WriteLine($"The integer variable contains the value: {variableForIntegerNumber}");
 * Use String interpolation when coding as a best practice.
 */
Console.WriteLine($"The integer variable contains the value: {variableForIntegerNumber}");

/*
 * A mistake would be to code the second WriteLine statement with the variable surrounded by quotes.
 * The computer would view variable surrounded by quotes as a string and print it out literally.
 * So above WriteLine use the computer looks inside the variable for the answer and below the what is between
 * the double quotes is literally printed.
 */

Console.Write("The integer variable contains the value: ");
Console.WriteLine("variableForIntegerNumber");