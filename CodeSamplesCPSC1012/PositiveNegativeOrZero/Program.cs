double numberInputByUser;

Console.WriteLine("Input a number: ");
numberInputByUser = double.Parse(Console.ReadLine());

if (numberInputByUser > 0)
{ 
    Console.WriteLine($"Number {numberInputByUser} is positive."); 
}
else if (numberInputByUser < 0)
{
    Console.WriteLine($"Number {numberInputByUser} is negative.");
}
else
{
    Console.WriteLine($"Number {numberInputByUser} is zero, neither positive or negative.");
}
