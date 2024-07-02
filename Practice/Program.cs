// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class PetPersonAgain
{
    public static void Main(string[] args)
    {
        bool isValid = false;
        string? readInput;
        string name = "";
        int age = 0;
        while (!isValid)
        {
            Console.WriteLine ("Please enter name: ");
            readInput = Console.ReadLine();
            if (readInput == "")
            {
                if (!int.TryParse(readInput, out age))
                {
                    isValid = true;
                    name = readInput;
                }
            }

        }
        
        while (isValid)
        {
            Console.WriteLine ("Please enter age: ");
            readInput = Console.ReadLine();
            if (int.TryParse(readInput, out age))
                isValid = false;
        }
        Person person1 = new Person(name, age);
        
        person1.Pets.Add(new Dog("Toy", 1));
        person1.Pets.Add(new Cat("Cat"));
        
        Console.WriteLine(person1);
        
        foreach (Pet pet in person1.Pets)
        {
            Console.WriteLine($"{pet} {pet.GetType()}");
        }
    }
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    
    public List<Pet> Pets { get; } = new List<Pet>();
    
    public override string ToString()
    {
        return $"{Name} {Age}";
    }
}

public abstract class Pet
{
    public string Name { get; set;}
    public Pet(string name)
    {
        Name = name;
    }
    
    public abstract void MakeSound();
}

public class Dog : Pet
{
    public int Age { get; set; }
    
    public Dog(string Name, int age) : base(Name) { Age = age; }
    
    public override void MakeSound()
    {
        Console.WriteLine("Bark bark");
    }
    
    public override string ToString()
    {
        return $"{Name}, {Age}";
    }
}

public class Cat : Pet
{
    public Cat(string Name) : base(Name) { }
    
    public override void MakeSound()
    {
        Console.WriteLine("Meow Meow");
    }
    public override string ToString()
    {
        return $"{Name}";
    }
}