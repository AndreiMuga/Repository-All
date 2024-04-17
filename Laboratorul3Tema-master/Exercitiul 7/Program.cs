/*Problem 7. Quotes in Strings
Declare two string variables and assign them with following value
    The "use" of quotations causes difficulties.
    Do the above in two different ways: with and without using quoted strings. Print the variables to ensure that their
value was correctly defined.
Expected Output
The "use" of quotations causes difficulties.
The "use" of quotations causes difficulties.*/

string primaVarianta = "The \"use\" of quotations causes difficulties.";
string aDouaVarianta = "The "+"use"+" of quotations causes difficulties.";
Console.WriteLine(primaVarianta);
Console.WriteLine(aDouaVarianta);//fara dublu ghilimele peste tot
Console.WriteLine("The \"use\" of quotations causes difficulties.");
string aTreiaVarianta = @"The ""use"" of quotations causes difficulties.";
Console.WriteLine(aTreiaVarianta);
