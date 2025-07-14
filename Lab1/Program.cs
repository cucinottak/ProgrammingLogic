using System;

/* 
* Name: Your Name
* Title: IT-1050 - Lab 1
*/

// Step 2
Console.WriteLine("Keira Cucinotta");
Console.WriteLine("IT-1050 - Lab 1");

// Step 3
int favoriteNumber = 7;
Console.WriteLine("My favorite number is " + favoriteNumber);

string favoriteLanguage = "Python";
Console.WriteLine("My favorite programming language is " + favoriteLanguage);

double programsWritten = 1;
Console.WriteLine("I have written " + programsWritten);

 bool hasExperience = true;
        Console.WriteLine("Do I have programming experience? " + (hasExperience ? "Yes" : "No"));
    // Step 4
const string schoolName = "Tri-c";
Console.WriteLine(schoolName);
// Step 5

double originalDouble = 9.78;
int castedInt = (int)originalDouble;
Console.WriteLine("Original double: " + originalDouble);
Console.WriteLine("Casted to int: " + castedInt);

int age = 20;
string ageString = Convert.ToString(age);
Console.WriteLine("Converted int to string: " + ageString);

bool isStudent = true;
string studentStatus = Convert.ToString(isStudent);
Console.WriteLine("Converted bool to string: " + studentStatus);

// Step 6

Console.Write("enter your name: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
string userName = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

Console.Write("enter your age: ");
int userAge = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Hi " + userName + ", You're " + userAge + " years old.");

int num1 = 10;
int num2 = 8;

int sum = num1 + 10;
Console.WriteLine("Addition (num1 + 10): " + sum);

int difference = num2 - 2;
Console.WriteLine("Subtraction (num2 - 2): " + difference);

int product = num1 * 3;
Console.WriteLine("Multiplication (num1 * 3): " + product);

int quotient = num2 / 2;
Console.WriteLine("Division (num2 / 2): " + quotient);

int remainder = num1 % 2;
Console.WriteLine("Modulus (num1 % 2): " + remainder);

// Step 8

float floatValue = 1.123456789f;
double doubleValue = 1.123456789;

Console.WriteLine("Float value: " + floatValue);
Console.WriteLine("Double value: " + doubleValue);

// Step 9

int counter = 10;

counter++; // increment by 1
Console.WriteLine("After increment (++): " + counter);

counter--; // decrement by 1
Console.WriteLine("After decrement (--): " + counter);

