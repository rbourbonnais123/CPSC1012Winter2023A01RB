char menuItem;
Console.WriteLine("Welcome to calculator");
menuItem = GetMenuItem();
while (menuItem != 'X')
{
    ProcessMenuItem(menuItem);
    menuItem = GetMenuItem();
}
Console.WriteLine("Thank you, goodbye");

static char GetMenuItem()
{
    char menuItem;
    DisplayMenu();
    menuItem = char.ToUpper(char.Parse(Console.ReadLine()));
    while (menuItem != 'F' && menuItem != 'C' && menuItem != 'I' && menuItem != 'X')
    {
        Console.WriteLine("Error - Invalid menu item");
        DisplayMenu();
        menuItem = char.ToUpper(char.Parse(Console.ReadLine()));
    }
    return menuItem;
}

static void DisplayMenu()
{
    Console.WriteLine("Please pick an item:");
    Console.WriteLine("F - Factorial");
    Console.WriteLine("C - Combinations");
    Console.WriteLine("I - Fibonacci");
    Console.WriteLine("X - Exit");
}

static void ProcessMenuItem(char menuItem)
{
    switch (menuItem)
    {
        case 'F':
            ProcessFactorial();
            break;
        case 'I':
            ProcessFibonacci();
            break;
        case 'C':
            ProcessCombinations();
            break;
    }
}

static void ProcessFactorial()
{
    int n,
        nFactorial;
    n = GetPositiveInteger("Enter n value");
    nFactorial = Factorial(n);
    Console.WriteLine($"{n} factorial is {nFactorial}");
}

static void ProcessFibonacci()
{
    int n,
        nthFibonacci;
    n = GetPositiveInteger("Enter position of fibonacci sequence");
    nthFibonacci = Fibonacci(n - 1);
    Console.WriteLine($"The fibonacci number at position {n} is {nthFibonacci}");
}

static void ProcessCombinations()
{
    int n,
        r,
        nChooseR;
    n = GetPositiveInteger("Enter number of objects to choose from");
    r = GetPositiveInteger("Enter number of object to choose");
    while (r > n)
    {
        Console.WriteLine($"Error - must be less than or equal to {n}");
        r = GetPositiveInteger("Enter number of objects to choose");
    }
    nChooseR = Combinations(n, r);
    Console.WriteLine($"There are {nChooseR} ways to choose {r} of {n} objects");
}

static int Factorial(int n)
{
    int nFactorial; ;
    for (nFactorial = 1; n > 1; n--)
        nFactorial *= n;
    return nFactorial;
}

static int Combinations(int n, int r)
{
    return Factorial(n) / (Factorial(r) * Factorial(n - r));
}

static int Fibonacci(int n)
{
    int count = 0,
        current = 0,
        previous = 1,
        previousPrevious = 0;

    for (count = 0; count < n; count++)
    {
        previousPrevious = previous;
        previous = current;
        current = previous + previousPrevious;
    }
    return current;
}

static int GetPositiveInteger(String prompt)
{
    int n;
    Console.WriteLine(prompt);
    n = int.Parse(Console.ReadLine());
    while (n < 0)
    {
        Console.WriteLine("Error: enter positive value");
        Console.WriteLine(prompt);
        n = int.Parse(Console.ReadLine());
    }
    return n;
}

