double numberInputByUser;

Console.WriteLine("Input age in years: ");
numberInputByUser = double.Parse(Console.ReadLine());

switch (numberInputByUser)
{
    case < 7:
        Console.WriteLine($"Age: {numberInputByUser} admission is free.");
        break;
    case < 18:
        Console.WriteLine($"Age: {numberInputByUser} admission for student is $9.80");
        break;
    case < 55:
        Console.WriteLine($"Age: {numberInputByUser} admission for adults is $11.35");
        break;
    default:
        Console.WriteLine($"Age: {numberInputByUser} admission for seniors is $10.00");
        break;
}
