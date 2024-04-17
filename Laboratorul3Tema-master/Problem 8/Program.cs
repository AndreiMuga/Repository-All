/*Problem 8
 * 
 * Isosceles Triangle
Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
 * Note that the © symbol may be displayed incorrectly at the console so you may need to change the console
character encoding to UTF-8 and assign a Unicode-friendly font in the console. Note also, that under old versions of
Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it
*/
using System.Text;

char simbol = '\u00A9';
Console.OutputEncoding = Encoding.UTF8; //m-am folosit de google sa schimb encoding-ul
Console.WriteLine("   "+simbol+"   ");
Console.WriteLine("  " + simbol + " " + simbol );
Console.WriteLine(" "+ simbol+"   "+simbol+" ");
Console.WriteLine(simbol + " " + simbol + " " + simbol+ " " + simbol);
//Bineinteles ca glumesc, doar ca nu am nici o idee cum pot face asta printr-o formula
//PS. Nu am vrut sa folosesc ChatGpt sau alt ajutor de genul asta.
