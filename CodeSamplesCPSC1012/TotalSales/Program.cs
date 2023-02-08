int days; 
double sales; 
double totalSales = 0.00; 

Console.Write("For how many days do you have sales figures for? ");
days = int.Parse(Console.ReadLine());

Console.WriteLine();

for (int count = 1; count <= days; count++)
{
    Console.Write($"Enter the sales figure for day #{count}: ");
    sales = double.Parse(Console.ReadLine());
    totalSales += sales;
}

Console.WriteLine($"\nTotal sales were: {totalSales:c}");

