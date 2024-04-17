/*Exchange Variable Values
Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using
some programming logic.Print the variable values before and after the exchange
Before:
a = 5
b = 10
After:
a = 10
b = 5*/

int a = 5;
int b = 10;
int temporar = a;
a = b;
b = temporar;
Console.WriteLine("Valoarea lui a este: " + a);
Console.WriteLine("Valoarea lui b este: " + b);