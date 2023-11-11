// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("Hello, World!");
Console.WriteLine("What's your first number");
var firstnumber = Convert.ToInt32(Console.ReadLine()); //Ask nyumber, give input
Console.WriteLine("What's your second number");
var secondnumber = Convert.ToInt32(Console.ReadLine());
var result = firstnumber + secondnumber;
//var result = 1 + 5; //Ask the result, no input
Console.WriteLine($"Sum of numbers {firstnumber} and {secondnumber} is {result}"); //give betterv result with sentence