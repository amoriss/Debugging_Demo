using Debugging_Demo;

// Logical Error
Console.WriteLine("World, Hello!");

//Runtime Error
//if you don't enter an int, there will be a runtime error
var answer = int.Parse(Console.ReadLine());

//tryparse prevents a runtime error
var couldParse = int.TryParse(Console.ReadLine(), out int number);

number = 10;

//locals window will show you all the variables within the scope you're in
//call stack will show which method i'm currently in

Methods.DoesSomething();
int x;
int y;
int z;

//Runtime - Divide by Zero Exception
Console.WriteLine("Enter in a number that I can divide by");

int divideBy= int.Parse(Console.ReadLine());

Console.WriteLine(number/divideBy);

//Runtime - Out of range exception

int[] array = new int[] { 1, 2, 3 };
Console.WriteLine(array[3]);