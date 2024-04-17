/*Write a method that returns the last digit of a given integer as an English word. Test the method with
different input values. Ensure you name the method properly
Example Output
Console.WriteLine(GetLast(512));    Two
Console.WriteLine(GetLast(514));    Four
Console.WriteLine(GetLast(5129010)) Zero*/
class Program
{ 
static void Main(string[] args)
{
    Console.WriteLine("Introduceti un numar: ");
    int cifraMea = int.Parse(Console.ReadLine());
    

    Console.WriteLine("ultima cifra a numarul introdus este: ");
    UltimaCifra(cifraMea);

}
    static void UltimaCifra(int cifraCitita)
    {

        int ultimaCifra = cifraCitita % 10;
        switch (ultimaCifra)
        {
            case 0:
                Console.WriteLine("Zero");
                break;
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            case 4:
                Console.WriteLine("Four");
                break;
            case 5:
                Console.WriteLine("Five");
                break;
            case 6:
                Console.WriteLine("Six");
                break;
            case 7:
                Console.WriteLine("Seven");
                break;
            case 8:
                Console.WriteLine("Eight");
                break;
            case 9:
                Console.WriteLine("Nine");
                break;

        }
    }
}