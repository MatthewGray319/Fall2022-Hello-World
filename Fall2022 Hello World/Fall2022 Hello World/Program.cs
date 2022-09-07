// Comment, comment
//Comment,comment
using System.Numerics;

Console.WriteLine("Hello, World!");

// Variables and objects
//Variable declaration
string Instructor;
// Variable assignment
Instructor = "Gavin";
// Variable Reassigment
Instructor = "Davis";

//All together
//If we use var instead of int, C# understands that Age is an integer based on what is on the right of the equal sign
var Age = 24;
Console.WriteLine(Age);

//Operators
//Performs some kind of basic operation / action on some values
//ex 5 + 13 = 18


//Assignment operator

//Arithmetic
// Addition, subtraction, multiplication, division, exponentiation (^), modulo (%) returns the remainder after dividing by a particular number
var StudentCount = 5 + 13;
Console.WriteLine(StudentCount);

var AverageClassSize = StudentCount / 4f;
Console.WriteLine(AverageClassSize);

var time = 13 % 12; //time has a value pf 1, the remainder
Console.WriteLine(time);

//Equality

// Comparison

//Increment


//Parsing
var ParsedValue = Int32.Parse("15"); //Integer 15
Console.WriteLine(ParsedValue+5);

// Pasted from Davis's link
int a, b, c;
a = 7;
b = 7;
c = b++;
var message = $"a = {a}";
var message2 = $"b = {b}";
var message3 = $"c = {c}";
Console.WriteLine(message);
Console.WriteLine(message2);
Console.WriteLine(message3);
