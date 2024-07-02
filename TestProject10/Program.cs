using System.Security.Cryptography;

string[] pallets = { "B14", "A11", "B12", "A13" };

// Array.Sort
Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Array.Reverse
Console.WriteLine(new string('-', 20));
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Array.Clear with To.Lower
Console.WriteLine(new string('-', 20));
Console.WriteLine("Before Clear...");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
Array.Clear(pallets, 0, 2);

Console.WriteLine("After Clear...");
foreach (var pallet in pallets)
{
        Console.WriteLine($"-- {pallet}");
}
// To.Lower
Console.WriteLine(new string('-', 20));
Console.WriteLine("After Clear then ToLower...");
foreach (var pallet in pallets)
{
    if (pallet != null) // to prevent error because of null value
        Console.WriteLine($"-- {pallet.ToLower()}");
}

// Array.Resize and add value
Console.WriteLine(new string('-', 20));
Console.WriteLine("Before Resize...");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
Array.Resize(ref pallets, 6);
Console.WriteLine("After Resize and add values...");
pallets[4] = "C01";
pallets[5] = "C02";
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Removing values using Resize
Console.WriteLine("Resize to remove values...");
Array.Resize(ref pallets, 4);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Transfering not null value to another array
Console.WriteLine(new string('-', 20));
Console.WriteLine("Transfering value to another array not including null...");
int count = 0;
string[] pallets2 = new string[count];

for (int i = 0; i < pallets.Length; i++)
{
   
    if (pallets[i] != null)
    {  
        count++;   
        Array.Resize(ref pallets2, count);
        pallets2[count - 1] = pallets[i];
    }
}

foreach (var pallet in pallets2)
{
    Console.WriteLine($"-- {pallet}");
}

// ToChar()
Console.WriteLine(new string('-', 20));
Console.WriteLine("ToChar then Array.Reverse return to string");
string name = "Marvin";
char[] valueArray = name.ToCharArray();
Array.Reverse(valueArray);
name = new string(valueArray);
Console.WriteLine(name);

// String.Join
Console.WriteLine(new string('-', 20));
Console.WriteLine("And use String.Join(', ', valueArray) ...");
string result = String.Join(",", valueArray);
Console.WriteLine(result);

// Split
Console.WriteLine(new string('-', 20));
Console.WriteLine("Use split to stringArray");
string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}


