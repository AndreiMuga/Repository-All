/*What type is it?
Write a program to print animal type by its name:
• dog->mammal
• crocodile, tortoise, snake -> reptile
• others -> unknown
Input Output
dog Mammal
snake Reptile
cat unknown*/
Console.WriteLine("Introduceti un nume de animal");


string animalulIntrodus = Console.ReadLine();


AnimalType (animalulIntrodus);
static void AnimalType(string animal)
{
    if (animal == "dog")
    {
        Console.WriteLine("Mammal");
    }
    else if(animal == "crocodile" || animal ==" totoise" || animal=="snake")
    {
        Console.WriteLine("Reptile");
    }
    else 
    { 
        Console.WriteLine("unknown");
    }
}