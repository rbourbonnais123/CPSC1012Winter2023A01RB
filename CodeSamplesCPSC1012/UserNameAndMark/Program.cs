string usersName;
double usersMark;

Console.WriteLine("Enter students name: ");
usersName = Console.ReadLine();

Console.WriteLine($"Enter mark for student {usersName}: ");
usersMark = double.Parse(Console.ReadLine());

if (usersMark < 50)
{
    Console.WriteLine($"Student {usersName} receives letter grade: F ");
}
else if (usersMark < 70)
{
    Console.WriteLine($"Student {usersName} receives letter grade: D ");
}
else if (usersMark < 80)
{
    Console.WriteLine($"Student {usersName} receives letter grade: C ");
}
else if (usersMark < 90)
{
    Console.WriteLine($"Student {usersName} receives letter grade: B ");
}
else if (usersMark <= 100)
{
    Console.WriteLine($"Student {usersName} receives letter grade: A ");
}
