Console.WriteLine("Enter string: ");
string? readInput = Console.ReadLine();
string reverseString = "";

if (readInput != null)
{
    for (int left = 1; left < readInput.Length - 1; left++)
    {
        Console.Write(readInput[left]);
        for (int space = 1; space < readInput.Length - 1; space++)
        {
            Console.Write(" ");
        }
        Console.WriteLine(readInput[readInput.Length - left -1]);
    }
    for (int i = 0; i < readInput.Length; i++)
    {
        reverseString = readInput[i] + reverseString;
    }
    Console.WriteLine(reverseString);
}
