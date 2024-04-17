/*Nullable Types – Exercise
Problem 4. Practice Nullable Types
1. Create a new C# project and in it, declare a nullable integer variable (int? num).
2.Assign a null value to the variable (num = null).
3. Print the variable on the console (Console.WriteLine(num)).
4. Add 42 to the variable (num += 5).
5. Print the variable on the console (Console.WriteLine(num)).
6. Assign a value of 10 to the variable (num = 10).
7. Print the variable on the console (Console.WriteLine(num)).

    Expected result

    10*/

int? num;
num = null;
Console.WriteLine(num);
num += 42;
Console.WriteLine(num);
num = 10;
Console.WriteLine(num);