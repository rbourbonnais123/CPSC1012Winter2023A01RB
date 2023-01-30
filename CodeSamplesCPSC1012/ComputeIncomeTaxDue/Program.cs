double incomeEntered;
double taxDue;

Console.WriteLine("Enter income to calculate tax for: ");

incomeEntered = double.Parse(Console.ReadLine());

if (incomeEntered <= 50000)
{
    taxDue = incomeEntered * .05;
    Console.WriteLine($"For {incomeEntered} tax due is: {taxDue}");
}
else if (incomeEntered <= 100000)
{
    taxDue = 2500 + ( (incomeEntered - 50000) * .07);
    Console.WriteLine($"For {incomeEntered:f2} tax due is: {taxDue:f2}");
}
else
{
    taxDue = 6000 + ((incomeEntered - 100000) * .09);
    Console.WriteLine($"For {incomeEntered} tax due is: {taxDue}");
}
