// See https://aka.ms/new-console-template for more information


/*
 * Given three test scores have the program:
 *  1. Display each test score
 *  2. Display the average of the three scores
 */

// Create three variables to hold the test score values

int testScore1, testScore2, testScore3;

// Create variable to hold the average of three test scores

double calculatedTestAverage;

// Assign the three test scores (hard coded vs propting for input)

testScore1 = 42;
testScore2 = 89;
testScore3 = 60;

/*
 * Calculate the test average.
 * dividing by 3.0 vs 3 puts a different answer into calculatedTestAverage  (Interger math)
 */

calculatedTestAverage = (testScore1 + testScore2 + testScore3) / 3.0;

// Print out the three scores for the test

Console.WriteLine($"Test scores for test were: {testScore1}, {testScore2}, {testScore3}");
Console.WriteLine($"Average for test was: {calculatedTestAverage:f2}");
