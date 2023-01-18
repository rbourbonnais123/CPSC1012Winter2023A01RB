// See https://aka.ms/new-console-template for more information

/*
 * The example below shows the difference between using Write and WriteLine.
 * Write does not automatically place a newline character at the end of the string.
 * WriteLine places a newline character at the end of the string.
 * This accounts for the difference in output.
 */

Console.WriteLine("Using WriteLine places a newline character at end of string so that next write statement prints on a new line.");
Console.Write("Using Write does not place a newline character so another write statement continues on same line.");
Console.Write("See how this new Write statement continues writing and there is no proper space after the first sentence. \n");

/*
 * Sometimes special a special Escape Sequence of characters is required to make things print properly.
 * For instance if you want to print " marks you need to use the \" to print it out.
 * The \n is an escape sequence in the line above which is why the line below is printing on a newline!
 */

Console.WriteLine("To print a backslash use the escape sequence backslash backslash and a \\ will be printed.");