
int numberInputByUser;
int runningTotal = 0;

Console.WriteLine("Input numbert to add to running total. Enter zero to stop input.");

numberInputByUser = int.Parse(Console.ReadLine());

while (numberInputByUser !=0)
{
    runningTotal = runningTotal + numberInputByUser;
    numberInputByUser = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Running total started at 0 and after all input is: {runningTotal}");
