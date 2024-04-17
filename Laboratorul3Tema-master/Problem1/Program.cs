/*Problem 1. Declare Variables
Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort,
int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.Choose a large
enough type for each number to ensure it will fit in it. Try to compile the code. Submit the source code of your Visual
Studio project as part of your homework submission*/
byte myBytec = 97;
sbyte mySByte = -115;
short myShort = -10000;
ushort myUShort = 52130;
int myInt = 4825932;
uint myUint;
long myLong;
ulong myULong;
Console.WriteLine(myBytec);
Console.WriteLine(mySByte);
Console.WriteLine("Urmatoarele 2 elemente, {0}, {1}", myShort, myUShort);
Console.WriteLine($"Ultima variabila: " + myInt);