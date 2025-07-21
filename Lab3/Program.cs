namespace Lab3;
using System;

//step 1
class Program
{
    static void Main()
    {
        Console.WriteLine("Numbers from 1 to 10:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        //step 2
        Console.WriteLine("Even numbers from 1 to 20:");
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        //step 3
        Console.WriteLine("Countdown from 5 to 1:");
        int count = 5;
        while (count >= 1)
        {
            Console.WriteLine(count);
            count--;
        }

        //step 4
        Console.WriteLine("Multiples of 10 from 10 to 1000");
        int num = 10;
        while (num <= 1000)
        {
            Console.WriteLine(num);
            num += 10;
        }

        //step 5
        Console.WriteLine("Seasons of the Year");
        string[] seasons = { "Spring", "Summer", "Fall", "Winter" };
        foreach (string season in seasons)
        {
            Console.WriteLine(season);
        }

        //step 6
        Console.WriteLine("Days of the Week");
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        Console.Write("Enter a number from 1 to 7: ");
        string input = Console.ReadLine();
        bool isValidNumber = int.TryParse(input, out int dayNumber);

        if (isValidNumber && dayNumber >= 1 && dayNumber <= 7)
        {
            Console.WriteLine($" {days[dayNumber - 1]}");
        }
        else
        {
            Console.WriteLine("Invalid input");
        }

        //step 7
        Console.WriteLine("Favorite Books and Authors");
        string[] books = { "1984", "To Kill a Mockingbird", "The Great Gatsby" };
        string[] authors = { "George Orwell", "Harper Lee", "F. Scott Fitzgerald" };

        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine($"\"{books[i]}\" by {authors[i]}");
        }

//step 8 
Console.WriteLine("Temperature Tracker");
        int[] temperatures = { 70, 80, 90, 60, 69 };

        Array.Sort(temperatures);

        Console.WriteLine("Temperatures in ascending order:");
        foreach (int temp in temperatures)
        {
            Console.WriteLine(temp);
        }

        Console.WriteLine($"Lowest temperature: {temperatures[0]}");
        Console.WriteLine($"Highest temperature: {temperatures[temperatures.Length - 1]}");
        
//step 9
        Console.WriteLine("Reverse Countdown");
        int[] countdown = { 5, 4, 3, 2, 1 };

        Array.Reverse(countdown);

        Console.WriteLine("Reversed countdown:");
        for (int i = 0; i < countdown.Length; i++)
        {
            Console.WriteLine(countdown[i]);
        }
    }
}
