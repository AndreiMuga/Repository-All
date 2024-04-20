namespace Laboratorul_6_Curs_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare strings
            string myFirstString = "Hello world again";
            Console.WriteLine(myFirstString);

            int myNumber = 43;
            Console.WriteLine(myNumber);

            string myNumberString = myNumber.ToString();


            //Manipulating strings
            //Concatenation
            
            
            string firstName = "Ionel";
            string lastName = "Popescu";
            //Console.WriteLine(firstName +" "+ lastName);
            //Interplation
            //Console.WriteLine($"{lastName}{lastName}");
            //Concatenation
            string fullNameWithConcat = String.Concat(firstName," ", lastName);
            Console.WriteLine(fullNameWithConcat);

          
        }
    }
}
