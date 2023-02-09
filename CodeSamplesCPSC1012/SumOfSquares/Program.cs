int sumOfSquares = 0;

int numberInputByUser;

Console.WriteLine("Input a number to compute sum of squares to: ");
numberInputByUser = int.Parse(Console.ReadLine());

for (int i = 1; i <= numberInputByUser; i++)
{
    sumOfSquares = sumOfSquares + (i * i);
}

Console.WriteLine($"Sum of all squares from 1 up to and including {numberInputByUser} is: {sumOfSquares}");