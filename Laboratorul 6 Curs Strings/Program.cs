using System;
using System.Diagnostics;
using System.Text;
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
            string fullName = firstName + " " +  lastName;
            
            //Console.WriteLine(firstName +" "+ lastName);
            //Interplation
            //Console.WriteLine($"{lastName}{lastName}");
            //Concatenation
            string fullNameWithConcat = String.Concat(firstName," ", lastName);
            Console.WriteLine(fullNameWithConcat);

            //Seaching in strings

            int index = fullName.IndexOf("Io");//Index = 0
            index = fullName.IndexOf("Popescu");// Index = 6
            index = fullName.IndexOf("POPESCU"); // Index = -1
            index = fullName.IndexOf("o", 1); // 1
            index = fullName.IndexOf("o", 3); // 7

#region
            //Extract substring
            //c:/Holiday/2025/1/nice_pic.png

            string path = "c:/Holiday/2025/1/nice_pic.png";

            //search the dot in the string
            int indexOfDot = path.IndexOf(".");

            //take the file extension
            string extension= path.Substring(indexOfDot+1);

            //extract the file name
            int lastIndexOfSlash = path.LastIndexOf("/");
            int substringLength = indexOfDot - lastIndexOfSlash - 1;

            string fileName = path.Substring (lastIndexOfSlash + 1,substringLength);
            Console.WriteLine($"{fileName}.{extension}");

            #endregion
            //Compare string
            string str1 = "oradea";
            string str2 = "Oradea";

            int result = string.Compare(str1, str2, true);
            if (result == 0)
            {
                Console.WriteLine("str 1 equals str 2");

            }
            if ( str1==str2)
            {
                //
            }
            if (str1.Equals(str2))
            {
                //
            }
            string listOfCities = "London, Paris, Iasi, Cluj, Bucuresti.";
            string[] cities = listOfCities.Split(',', ' ', '.');
            foreach (string city in cities) 
            {
                if(!string.IsNullOrEmpty(city))
                { 
               Console.WriteLine (city.ToUpper());
               Console.WriteLine(city.ToLower());
                }

            }


            //Trim

            string mySpaceString = "     this is a string    ";

            Console.WriteLine(mySpaceString.TrimStart());
            Console.WriteLine(mySpaceString.TrimEnd());
            Console.WriteLine(mySpaceString.Trim());

            string myFunnyString = "-+++++++this is a string2=== ----";
            Console.WriteLine(myFunnyString.Trim('-', '+',' ', '='));
            Console.WriteLine(myFunnyString.Replace('+', '&'));


            //
/*
            StringBuilder stringBuilder = new StringBuilder(); //Facem string builder si stergem concatenarea //myCoolString += i.ToString(); de mai jos
            var stopWatch = new Stopwatch();
            string myCoolString = "Counting bottle";

            
            stopWatch.Start();
            for (int i = 0 ; i <10000; i++)
            {
                //myCoolString += i.ToString();
                stringBuilder.Append(i.ToString());
                Console.WriteLine(i.ToString());
                
            }
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed.TotalSeconds.ToString());*/


            //Formatting Strings
            double d = 0.375;
            /*string e = d.ToString("P3");
            Console.WriteLine(e);
            string f = d.ToString("C5");
            Console.WriteLine(f);*/

            string infoToDisplay = d.ToString("P2");
            Console.WriteLine(infoToDisplay);

            string myFormatterString = String.Format("{0:F5}", d);
            Console.WriteLine(myFormatterString);

            



        }
    }
}
