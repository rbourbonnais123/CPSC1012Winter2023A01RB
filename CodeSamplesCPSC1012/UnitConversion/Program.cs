
int selectedConversion;
double valueToConvert;

Console.WriteLine("Select unit conversion:\n" +
    "1. Pounds to Kilograms\n" +
    "2. Fluid Ounces(U.S.) to Litres\n" +
    "3. Inches to Centimeters\n" +
    "4. Fahrenheit to Celsius");

selectedConversion = int.Parse(Console.ReadLine());

Console.WriteLine("Enter value to convert.");
valueToConvert = double.Parse(Console.ReadLine());

switch (selectedConversion)
{
    case 1:
        Console.WriteLine($"Converting {valueToConvert} pounds to kilograms is:  {valueToConvert / 2.2046} kilogram.");
        break;
    case 2:
        Console.WriteLine($"The converted value is: {valueToConvert / 33.8140226}");
        break;
    case 3:
        Console.WriteLine($"The converted value is: {valueToConvert / .39370}");
        break;
    case 4:
        Console.WriteLine($"The converted value is: {(valueToConvert - 32) / 1.800}");
        break;
    default:
        Console.WriteLine("Must select 1, 2, 3, or 4.");
        break;
}
