namespace Laboratorul_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare new array
            int[] myArray = new int[3];//size of the array
            myArray[0] = 35;
            myArray[1] = -10;
            myArray[2] = 500;
            // myArray[4] = 625; //this will throw an exception

            myArray[1] = 95012;
            string[] daysOfTheWeek = { "Luni", "Marti", "Joi", "Sambata", };

            //accessing elements from an arraystringstring
            string[] reverseDays = new string[6];
            int length = daysOfTheWeek.Length;

            for (int i=0; i<length; i++)
            {
                reverseDays[length -i -1 ] = daysOfTheWeek[i];

            }
            Console.WriteLine(reverseDays[0]);

            //printing an array
            Console.WriteLine(daysOfTheWeek);//Doesn`t print the elements; Output: System.String[]

            //for loop
            for(int i=0; i<length ; i++)
            {
                Console.WriteLine(daysOfTheWeek[i]);
            }
            foreach(string item in daysOfTheWeek) 
            {
                Console.WriteLine(item);
            }

            //while
            int index = 0;
            while(index < daysOfTheWeek.Length)
            {
                Console.WriteLine(daysOfTheWeek[index]);
                index++;
            }

            index = 0 ;
            do
            {
                Console.WriteLine(daysOfTheWeek[index]);
                index++;
            }
            while(index < daysOfTheWeek.Length);

            //Reading array from Console
            Console.WriteLine("Please give an array size: ");
            int arraySize = int.Parse(Console.ReadLine());

            int[] myArrayFromConsolle = new int[arraySize];
            
            Console.WriteLine("Please input the values of the array: ");
            for (int i=0; i< arraySize ; i++)
            {
                myArrayFromConsolle[i] = int.Parse(Console.ReadLine());
            }

            //Coping an array
            string[] myArrayCopy = daysOfTheWeek;
            myArrayCopy[0] = "alabala";
            Console.WriteLine(myArrayCopy[0]);
            Console.WriteLine(daysOfTheWeek[0]);

            string[] myArrayClone = (string[])daysOfTheWeek.Clone();
            myArrayClone[0] = "Duminica";

            object a = 1;
            object b = new char[2];
            Console.WriteLine(myArrayClone[0]);
            Console.WriteLine(daysOfTheWeek[0]);

            //resize the array

            int[] intArray = new int[5];
            int[] copyArray = intArray;//create backupp

            intArray = new int[6];

            for(int i=0; i < 5; i++)
            {
                intArray[i] = copyArray[i];
            }
            intArray [5] = 10;
        }
            
    }
}
