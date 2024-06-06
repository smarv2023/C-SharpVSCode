// Selection Sort O(n^2)

using System.Reflection;

public class Sortings
{
    public static void Main(string[] args)
    {
        int[] numbers = {9 ,8 ,10 , 1, 7, 5, 2, 3, 4, 5,};

        SelectionSort(numbers);
        
        foreach (int i in numbers)
            Console.WriteLine(i);
        
    }
    static void SelectionSort(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            int min = i;
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[min] > numbers[j])
                {
                    min = j;
                }
            }
        
            // int temp = numbers[min];
            // numbers[min] = numbers[i];
            // numbers[i] = temp;
            (numbers[i], numbers[min]) = (numbers[min], numbers[i]);
        }
    }

    
}

    


