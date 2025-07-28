using System;

class Car
{
    public string model;
    public string color;
    public int year;

    // Example method to display car details.
    public void Display()
    {
        Console.WriteLine("Car Details:");
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Year: " + year);
    }

    internal void Start()
    {
        Console.WriteLine("The car is starting.");
    }

    internal void Drive(int v)
    {
        Console.WriteLine("The car drove " + "50" + " miles.");
    }

    internal string GetDescription()
    {
       return year + " " + color + " " + model;
    }

    public void Repaint(string newColor)
    {
    color = newColor;
    Console.WriteLine("The car has been repainted to " + color + ".");
    }
}

class Program
{
    static void Main()
    {
        // Creating a Car object and assigning values to its properties
        Car myCar = new Car();
        myCar.model = "Civic";
        myCar.color = "Black";
        myCar.year = 2020;

        myCar.Display(); // Calling the Display method
                         //step 1
        myCar.Start();
        //step 2
        myCar.Drive(50);
        //step 3
        string description = myCar.GetDescription();
        Console.WriteLine(description);
        //step 4
        myCar.Repaint("Red");
        Console.WriteLine("Updated color: " + myCar.color);
    }
}