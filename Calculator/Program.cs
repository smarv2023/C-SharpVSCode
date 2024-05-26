string? readInput;
int firstNumber;
int secondNumber;


Console.WriteLine("Calculator");
firstNumber = inputValidator("first");
secondNumber = inputValidator("second");
Calculator(firstNumber, secondNumber);


void Calculator(int firstNumber, int secondNumber)
{
    decimal answer = 0;
    readInput = "";
    Console.Write("Select Operator (+, -, *, /): "); 
    while (readInput == "")
    {
        readInput = Console.ReadLine();
        switch (readInput)
        {
            case "+":
                answer = firstNumber + secondNumber;
                break;
            case "-":
                answer = firstNumber - secondNumber;
                break;
            case "*":
                answer = firstNumber * secondNumber;
                break;
            case "/":
                if (secondNumber == 0)
                {
                    Console.WriteLine("Invalid Operation cannot devided by 0: ");
                    readInput = "";
                }
                else
                    answer = (decimal)firstNumber / secondNumber;
                break;
            default:
                Console.Write("Please select from operators (+, -, *, /): ");
                readInput = "";
                break;
        }
    }
    Console.WriteLine($"{firstNumber} {readInput} {secondNumber} = {answer}");
}

int inputValidator(string entry)
{
    int number = 0;
    bool isValid = false;
    do
    {
        Console.Write($"Enter {entry} number: ");
        readInput = Console.ReadLine();

        if (readInput != null)
        {
            isValid = int.TryParse(readInput, out number);
        }
    } while (!isValid);

    return number;
}