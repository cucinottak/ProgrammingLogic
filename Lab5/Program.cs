using System;

public class Animal
{
    //step 1
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}
//step 2
public class Cat : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The cat says: meow");
    }
}

public class Dog : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}

//step 3
class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();
        Animal myCat = new Cat();
        Animal myDog = new Dog();

        myAnimal.animalSound();
        myCat.animalSound();
        myDog.animalSound();
    }
}
