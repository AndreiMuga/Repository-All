
/*What day is it?
Write a method that takes an integer in [1 -7] range as a parameter and returns a string.
The parameter represents the day of the week, and it should return the name of the corresponding day.
Input Output
1 Monday
6 Saturday*/



Console.WriteLine("Introduce the day of the week by using a numeric charcater 1-7: ");
int day = int.Parse(Console.ReadLine());

Console.WriteLine("The day of the week introduced is: ");
ZiuaDinSaptamana(day);





static void ZiuaDinSaptamana( int ziua)
{
    switch (ziua)
    {
        case 1:
            Console.WriteLine("Monday");
            break;
        case 2:
            Console.WriteLine("Tuesday");
            break;
        case 3:
            Console.WriteLine("Wednesday");
            break;
        case 4:
            Console.WriteLine("Thursday");
            break;
        case 5:
            Console.WriteLine("Friday");
            break;
        case 6:
            Console.WriteLine("Saturday");
            break;
        case 7:
            Console.WriteLine("Sunday");
            break;
    }
}