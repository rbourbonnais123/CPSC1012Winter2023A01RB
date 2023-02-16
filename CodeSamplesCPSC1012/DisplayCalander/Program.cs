int numberOfDaysInMonth,
    printStartLocation = 1;
string firstDayOfMonth,
    displayCalander = "";

Console.WriteLine("Enter number of days in month: ");
numberOfDaysInMonth = int.Parse(Console.ReadLine());

Console.WriteLine("Enter day (Sun, Mon, Tue, Wed, Thu, Fri, or Sat) to start printing.");
firstDayOfMonth = Console.ReadLine();

// Determine starting location to print based on day entered by user.
switch (firstDayOfMonth)
{
    case "Sun":
        printStartLocation = 1;
        break;
    case "Mon":
        printStartLocation = 2;
        break;
    case "Tue":
        printStartLocation = 3;
        break;
    case "Wed":
        printStartLocation = 4;
        break;
    case "Thu":
        printStartLocation = 5;
        break;
    case "Fri":
        printStartLocation = 6;
        break;
    case "Sat":
        printStartLocation = 7;
        break;
    default:
        Console.WriteLine("Did not enter one of: Sun,Mon,Tue, etc. so will print starting on 'Sun'");
        break;
}

// Prefix padding to the displayCalander string based on the print starting location
for (int i = 2; i <= printStartLocation; i++)
{
    displayCalander = displayCalander + $"{"",5}";
}

// Append calander numbers to displayCalander using escape sequence \n when appropriate
for (int i = 1; i <= numberOfDaysInMonth; i++)
{
    if (printStartLocation % 7 == 0)
    {
        displayCalander = displayCalander + $"{i,5}";
        displayCalander = displayCalander + "\n";
    }
    else
    {
        displayCalander = displayCalander + $"{i,5}";
    }
    printStartLocation++;
}
// Write out header and displayCalander
Console.WriteLine($"\n{"Sun",5}{"Mon",5}{"Tue",5}{"Wed",5}{"Thu",5}{"Fri",5}{"Sat",5}");
Console.WriteLine($"{displayCalander}");
