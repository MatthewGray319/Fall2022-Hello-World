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

//Booleans
// Boolean is a data type where the only values are "true" and "false", on vs. off, 1 vs. 0 
var isSunny = true;


//Equality
// Checks to see if value of Instructor is the same as "Davis"
var isDavis = Instructor == "Davis";

//Not Equal !=
// Returns true if the two values are not the same
var isGavin = Instructor != "Davis";

// Comparison
// Checks to see if a value is greater than (>), less than (-), greater than or equal to (>=), less than or equal to (<=
var isGreaterThan = 18 >= 25; //checking is it greater than OR is it equal to? if one part is true, the whole part is true

//Boolean Operators
// We have some specific operators defined for actions between two boolean values

//OR operator || ( | if you want to run both sides)
// Returns true of the ;eft is true or the right is true
// true || false --> true
// false || true --> true
// true || true --> true
// false || false --> false
var willGoOutside = isSunny || isDavis;

// AND Operator && (& if you want to run both sides)
// The AND operator returns true if the left and the right values are true
// true || false --> false
// false || true --> false
// true || true --> true
// false || false --> false
var isRaining = true;
var isCold = true;
var willNotDrive = isRaining && isCold; // true && true --> true


// NOT operator !
// Returns the opposite of a given boolean value
// !true --> false
// !false --> true
var willDrive = !willNotDrive;

// Exclusive OR (XOR) operator ^
// Only returns true when the left or right are true, false when both are true
// true ^ false --> true
// false ^ true --> true
// true ^ true --> false
// false ^ false --> false

//Increment


bool one = true;
bool two = false;
bool three = true;

// !two && (!true && (one || two)) || three
// AND has precedence over OR

var four = !two && (!true && (one || two)) || three;
Console.WriteLine(four);

//Parsing
var ParsedValue = Int32.Parse("15"); //Integer 15
Console.WriteLine(ParsedValue+5);

// Pasted from Davis's link
// int a, b, c;
// a = 7;
// b = 7;
// c = b++;
// var message2 = $"b = {b}";
// var message3 = $"c = {c}";
// Console.WriteLine(message);
// Console.WriteLine(message2);
// Console.WriteLine(message3);
