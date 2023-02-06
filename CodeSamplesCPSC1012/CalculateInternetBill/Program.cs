const double PackagePriceA = 10.95,
    PackagePriceB = 13.95,
    PackagePriceC = 19.95,
    OverchargeForPackageA = 2.00,
    OverchargeForPackageB = 1.00;

const int HoursAllowedForPackageA = 10,
    HoursAllowedForPackageB = 20;

string servicePackage;
int hoursUsed;
double customerBill = 0.00;

Console.WriteLine("Enter the service package indicator (A, B, or C): ");
servicePackage = Console.ReadLine();

switch (servicePackage)
{
    case "A":
        customerBill = PackagePriceA;
        Console.WriteLine("Enter the number of hours used: ");
        hoursUsed = int.Parse(Console.ReadLine());
        if (hoursUsed > HoursAllowedForPackageA)
        {
            customerBill = PackagePriceA + ((hoursUsed - HoursAllowedForPackageA) * OverchargeForPackageA);
        }
        break;
    case "B":
        customerBill = PackagePriceB;
        Console.WriteLine("Enter the number of hours used: ");
        hoursUsed = int.Parse(Console.ReadLine());
        if (hoursUsed > HoursAllowedForPackageB)
        {
            customerBill = PackagePriceB + ((hoursUsed - HoursAllowedForPackageB) * OverchargeForPackageB);
        }
        break;
    case "C":
        customerBill = PackagePriceC;
        break;
    default:
        Console.WriteLine("Unable to calculate customer bill package (A, B, or C) was not entered.");
        break;
}

Console.WriteLine($"Customer bill total is: {customerBill:c}");

//if (servicePackage != "C")
//{
//    Console.WriteLine("Enter hours used: ");
//    hoursUsed = int.Parse(Console.ReadLine());

//    if (servicePackage == "A")
//    {
//        customerBill = 9.95;
//        if (hoursUsed > 10)
//        {
//            customerBill = 9.95 + ((hoursUsed - 10) * 2.00);
//        }
//    }
//    else
//    {
//        customerBill = 13.95;
//        if (hoursUsed > 20)
//        {
//            customerBill = 13.95 + ((hoursUsed - 20) * 1.00);
//        }
//    }
//}
//else
//{
//    customerBill = 19.95;
//}



