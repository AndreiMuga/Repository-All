/*
Write a method GetMin() with two parameters that returns the smallest of two integers. Write a
method that reads 2 integers from the console and prints the smalles of them using the
method GetMin().*/

Console.WriteLine("Scrieti primul parametru: ");
int primulParametru = int.Parse(Console.ReadLine());
Console.WriteLine("Scrieti al doilea parametru: ");
int alDoileaParametru = int.Parse(Console.ReadLine());


Console.WriteLine($"Cel mai mic parametru este: " + GetMin(primulParametru, alDoileaParametru));


static int GetMin(int primulParametru, int alDoileaParametru)
{
    int minimul = Math.Min(primulParametru, alDoileaParametru);
    return minimul;
}