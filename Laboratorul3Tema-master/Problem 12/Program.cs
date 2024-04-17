/*Problem 12. Null Values Arithmetic
Create a program that assigns null values to an integer and to a double variable. Try to print these variables at the
console. Try to add some number or the null literal to these variables and print the result.*/

int? numarul1 = null;
double? numarul2 = null;
Console.WriteLine(numarul1);
Console.WriteLine(numarul2);
numarul1 += 123;
numarul2 += 22.34d;
Console.WriteLine(numarul1);
Console.WriteLine(numarul2);
//am incercat sa fac exact ce spune in exercitiu, insa nu putem aduna null + un numar