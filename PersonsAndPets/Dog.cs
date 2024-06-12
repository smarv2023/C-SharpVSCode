namespace PersonsAndPets;

public class Dog(string petName) : Pet(petName)
{
    public string CPetName { get; set; } = petName; // Invoke if you want to change the name of the Pet

    public override string MakeNoise()
    {
        return "Bark bark";
    }
}

/* 
 public class Dog : Pet
{
    public Dog(string petName) : base(petName){}

    public override string MakeNoise()
    {
        return $"Bark bark";
    }
} 
 */