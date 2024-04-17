/*
Ex 2
Overload the method so that it can receive float numbers
*/
using System.ComponentModel.Design;

static class Proogram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduceti primul numar: ");
        float nr1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Introduceti al doilea numar: ");
        float nr2 = float.Parse(Console.ReadLine());

        Console.WriteLine("Cel mai mic numar este: ");
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
}