// See https://aka.ms/new-console-template for more information

double userNumberOne, userNumberTwo, userNumberThree, calculateMean;

Console.WriteLine("Enter your first value.");
userNumberOne = double.Parse(Console.ReadLine());

Console.WriteLine("Enter your second value.");
userNumberTwo = double.Parse(Console.ReadLine());

Console.WriteLine("Enter your third value.");
userNumberThree = double.Parse(Console.ReadLine());

calculateMean = (userNumberOne + userNumberTwo + userNumberThree) / 3;

Console.WriteLine($"Calculate mean was: {calculateMean}");


