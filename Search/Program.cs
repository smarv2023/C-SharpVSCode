﻿/* 
    Searches
*/
// Linear Search O(n)

Console.WriteLine("Linear Search");
int[] numbers = [ 10, 8, 2, 1, 3, 4, 5,];
int key = 3;
int? result;
/*
result = LinearSearch(key);

if (result == -1)
    Console.WriteLine($"{key} does not exist");

else
    Console.WriteLine($"{key} found at index {result}");


int LinearSearch(int key)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (key == numbers[i])
            return i;
    }
    return -1;
}
*/
// Binary Search O(log n)
Console.WriteLine("Binary Search");
List<int> listNumbers = new();
listNumbers = [ 10, 8, 2, 1, 9, 3, 7, 4, 6, 5 ]; // 1 - 10
listNumbers.Sort();
key = 8;
result = BinarySearch(key);

if (result == -1)
    Console.WriteLine($"{key} does not exist");

else
    Console.WriteLine($"{key} found at index {result}");


int BinarySearch(int key)
{
    int low = 0;
    int high = listNumbers.Count - 1;
    while (low <= high)
    {
        int mid = low + (high - low) / 2;
  
        if (listNumbers[mid] == key)
            return mid;

        if (listNumbers[mid] < key)
            low = mid + 1;

        else
            high = mid - 1;
        
        //Console.WriteLine($"Low:{low}\nmid:--{mid}\nhigh:{high}");
    }
    return -1;
}
/*
Console.WriteLine("Recursive Binary Search");
result = BinarySearchR(key, 0, listNumbers.Count - 1);
if (result == -1)
    Console.WriteLine($"{key} does not exist");

else
    Console.WriteLine($"{key} found at index {result}");

int BinarySearchR(int key, int low, int high)
{
    int mid = low + (high - low) / 2;

    if (low > high)
        return -1;

    if (listNumbers[mid] == key)
        return mid;

    if (listNumbers[mid] < key)
        //low = mid + 1;
        return BinarySearchR(key, mid + 1, high);

    else
        //high = mid - 1;
        return BinarySearchR(key, low, mid - 1);
}
*/