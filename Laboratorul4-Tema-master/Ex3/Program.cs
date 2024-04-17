/*
Ex 3
Overload the previous methods so it can receive decimal numbers
*/
using System.ComponentModel.Design;

static class Proogram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduceti primul numar: ");
        decimal nr1 = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Introduceti al doilea numar: ");
        decimal nr2 = decimal.Parse(Console.ReadLine());

        GetMin(nr1, nr2);
    }

    static void GetMin(int primul, int alDoilea)
    {


        int numarul = Math.Min(primul, alDoilea);
        Console.WriteLine("Cel mai mic numar este: " + numarul);
    }

    static void GetMin(float primul, float alDoilea)
    {
        float numarul = Math.Min(primul, alDoilea);
        Console.WriteLine("Cel mai mic numar este: " + numarul);
    }

    static void GetMin(decimal primul, decimal alDoilea)
    {
        decimal numarul = Math.Min(primul, alDoilea);
        Console.WriteLine("Cel mai mic numar este: " + numarul);
    }
}