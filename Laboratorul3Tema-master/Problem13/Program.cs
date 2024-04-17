/*Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. Note that
we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point
arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant
eps. Examples:
*/
Console.WriteLine("Introduce the first number to compare: ");
decimal primulNumar= decimal.Parse(Console.ReadLine());
Console.WriteLine("Introduce the second number that you want to compare ");
decimal alDoileaNumar = decimal.Parse(Console.ReadLine());
bool rezultat;
double eps = 0.000001;
decimal rezultat1 = Math.Abs(alDoileaNumar- primulNumar);
decimal rezultat2 = primulNumar - alDoileaNumar;



if (rezultat1  <= (decimal)eps)
{
    rezultat = true;
}
else
{ 
    rezultat= false;
}

Console.WriteLine("Numerele introduse sunt: " + rezultat);
