// FizzBuzzBazz

for (int i = 0; i < 100; i++)
{
    string outPut = "";
    if (i % 3 == 0)
        outPut += "Fizz";
    if (i % 5 == 0)
        outPut += "Buzz";
    if (i % 7 == 0)
        outPut += "Bazz";

    Console.WriteLine($"{i} {outPut}");
}
