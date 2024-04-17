/*Ex 1
Write a method GetMin() with two parameters that returns the smallest of two integers. Write a
method that reads 2 integers from the console and prints the smalles of them using the
method GetMin().
*/
using System.ComponentModel.Design;

static class Proogram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduceti primul numar: ");
        int nr1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduceti al doilea numar: ");
        int nr2 =Convert.ToInt32(Console.ReadLine());

        GetMin(nr1, nr2);
    }

    static void GetMin(int primul, int alDoilea)
    {

        
        int numarul = Math.Min(primul, alDoilea);
        Console.WriteLine("Cel mai mic numar este: "+ numarul);
    }
}