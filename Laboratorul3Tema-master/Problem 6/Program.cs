/*Problem 6. Strings and Objects
Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it
with the concatenation of the first two variables (mind adding an interval between). Declare a third string variable
and initialize it with the value of the object variable (you should perform type casting).
*/

var salutul = "Hello";
var interlocutorul = "World";
var concatenare = salutul + " " +  interlocutorul;
//m-am gandit ca pot folosi si object pentru salutul si interlocutorul

concatenare = (string)concatenare;
Console.WriteLine(concatenare);