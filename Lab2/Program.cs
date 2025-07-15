using System;
//step 1
int a = 10;
int b = 5;
int c = 15;

bool isAGreaterThanB = a > b;
bool isALessThanC = a < c;
bool isAGreaterThanBoth = a > b && a > c;

bool result1 = (a > b) && (a < c); // true && true => true
bool result2 = (a > c) || (b < c); // false || true => true

Console.WriteLine("a > b: " + isAGreaterThanB);
Console.WriteLine("a < c: " + isALessThanC);
Console.WriteLine("a > b && a > c: " + isAGreaterThanBoth);
Console.WriteLine("(a > b) && (a < c): " + result1);
Console.WriteLine("(a > c) || (b < c): " + result2);

//step 2
bool isRaining = true;
            bool haveUmbrella = false;

if (isRaining && !haveUmbrella)
{
    Console.WriteLine("Take an umbrella!");
}
else
{
    Console.WriteLine("You're good to go!");
                
 //step 3
            }
         Console.Write("Enter age: ");
            
            int age = int.Parse(Console.ReadLine());

            if (age < 5)
            {
                Console.WriteLine("Ticket is free!");
            }
            else if (age >= 5 && age <= 12)
            {
                Console.WriteLine("Child ticket: $5");
            }
            else if (age >= 13 && age <= 64)
            {
                Console.WriteLine("Standard ticket: $10");
            }
            else // age >= 65
            {
                Console.WriteLine("Senior ticket: $6");
            }

//step 4
Console.Write("Enter a number (1-7) for the day of the week: ");

if (int.TryParse(Console.ReadLine(), out int day))
{
    switch (day)
    {
        case 1:
            Console.WriteLine("Monday");
            break;
        case 2:
            Console.WriteLine("Tuesday");
            break;
        case 3:
            Console.WriteLine("Wednesday");
            break;
        case 4:
            Console.WriteLine("Thursday");
            break;
        case 5:
            Console.WriteLine("Friday");
            break;
        case 6:
            Console.WriteLine("Saturday");
            break;
        case 7:
            Console.WriteLine("Sunday");
            break;
        default:
            Console.WriteLine("Invalid day!");
            break;
    }
}
