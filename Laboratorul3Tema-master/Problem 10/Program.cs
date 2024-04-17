/*//Problem 10. Employee Data
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

A marketing company wants to keep record of its employees. Each record would have the following characteristics:
● First name
● Last name
● Age (0...100)
● Gender (m or f)
● Personal ID number (e.g. 8306112507)
● Unique employee number (27560000...27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
Use descriptive names. Print the data at the console.
First name: Amanda
Last name: Jonson
Age: 27
Gender: f
Personal ID: 8306112507
Unique Employee number: 27563571*/

string firstName = "Amanda";
string lastName = "Johnson";
byte age = 28;
char gender = 'f';
long personalIdNumber = 8306112507;
int uniqueEmployeeNumber = 27563571;

Console.WriteLine("First name: " + firstName);
Console.WriteLine("Last name: " + lastName);
Console.WriteLine("Age: " + age);
Console.WriteLine("Gender: " + gender);
Console.WriteLine("Personal ID: " + personalIdNumber);
Console.WriteLine("Unique Employee number: " + uniqueEmployeeNumber);

