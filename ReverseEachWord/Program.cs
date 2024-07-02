
/*
    Write code to reverse each word in a message
    Select and delete all code lines in the Visual Studio Code Editor.

    Update your code in the Visual Studio Code Editor as follows:
    string pangram = "The quick brown fox jumps over the lazy dog";
    Write the code necessary to reverse the letters of each word in place and display the result.
    In other words, don't just reverse every letter in the variable pangram. Instead, you'll need to reverse just the letters in each word, but print the reversed word in its original position in the message.
    Your code must produce the following output:

*/
// My solution
string pangram = "The quick brown fox jumps over the lazy dog";
string result = ReversingStrings(pangram);

Console.WriteLine(result);

string ReversingStrings(string pangram)
{
    string[] newMessage = pangram.Split(" ");

    for(int i = 0; i < newMessage.Length; i ++)
    {
        char[] chars = newMessage[i].ToCharArray();
        Array.Reverse(chars);
        newMessage[i] = String.Join("", chars);
    }
    // Join
    string outPut = String.Join(" ", newMessage);
    return outPut;
}

// Another solution

// Step 1
string[] message = pangram.Split(' ');

// Step 2
string[] newMessage = new string[message.Length];

// Step 3
for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

// Step 4
string result2 = String.Join(" ", newMessage);
Console.WriteLine(result2);
