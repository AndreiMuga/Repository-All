﻿using System.ComponentModel;
using System.Drawing;
using System.Text;
using static System.Net.Mime.MediaTypeNames;


namespace Laboratorul_7_Exercitii_Curs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Exercitiul 1
             * Write a method to display formatted text(width= 50) as output.
   For example: If I have a text that's 231 characters long, 
    the formatted string should have maximum of 50 characters per line. 
    In this case we will have 5 lines of text.

Text: Lorem ipsum dolor sit amet, consectetur adipiscing elit.Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.     */
        
        string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.";
            DisplayFormattedText(text, 50);

            static void DisplayFormattedText(string text, int maxWith)
            {
                StringBuilder formattedText = new StringBuilder();
                //Split the text into lines with a maximum width of maxWidth
                for (int i = 0; i< text.Length; i +=maxWith)
                {
                    int lineLength = Math.Min(maxWith, text.Length - i);
                    formattedText.AppendLine(text.Substring(i, lineLength));
                }
                Console.WriteLine(formattedText.ToString());
            }
        }
    }
}
