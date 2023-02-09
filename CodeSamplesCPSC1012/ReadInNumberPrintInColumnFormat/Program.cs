
int numberInputByUser;

Console.WriteLine("Enter a number.");

numberInputByUser = int.Parse(Console.ReadLine());

while (numberInputByUser != 0)
{
    int numberToPrint;
    numberToPrint = numberInputByUser % 10;
    Console.WriteLine(numberToPrint);
    numberInputByUser = numberInputByUser / 10;
}
