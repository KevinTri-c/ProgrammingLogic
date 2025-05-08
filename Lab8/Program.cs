namespace Lab8;
using System;

class Animal
{
    public virtual void AnimalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Cat : Animal
{
    public override void AnimalSound()
    {
        Console.WriteLine("The cat says: meow");
    }
}

class Dog : Animal
{
    public override void AnimalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}

class Program
{
    static void Main()
    {
        Animal a = new Animal();
        Animal c = new Cat();
        Animal d = new Dog();

        a.AnimalSound(); // Outputs: The animal makes a sound
        c.AnimalSound(); // Outputs: The cat says: meow
        d.AnimalSound(); // Outputs: The dog says: bow wow
    }
}

