// See https://aka.ms/new-console-template for more information

/*
 * A bag of 26 cookies has 10 servings.
 * A serving is 175 calories.
 * Therefore calories per cookie is equal to 175 / 2.6  ( 67.30769230769231 per cookie)
 */

const double caloriesPerCookie = 67.30769230769231;

/*
 * Create a variable to hold the number of cookies ate.
 * Place a hard coded value into the variable.
 */

int cookiesAte = 2;

/*
 * Create a variable to hold the calculated number of calories
 * based on the number of cookies ate.
 */

double calculatedCalories;

// Perform the calculation

calculatedCalories = cookiesAte * caloriesPerCookie;

/*
 * Write out the calories calculated based on the number of cookies ate
 * Note the use of formating the number variable using f2
 * f1 is one decimail place, f2 is two decimal places, f3 is three decimal places, etc. etc.
 */

Console.WriteLine($"Calories consumed based on number of cookies ate is: {calculatedCalories:f2}");
