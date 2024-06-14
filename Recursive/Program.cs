//Fibonacci O(n)

int n = 100;
double[] memo = new double[n + 1];
/* 
for (int i = 0; i <= n; i++)
{
    memo [i] = fibMemoization(i, memo);
    Console.WriteLine(i + ": " + memo[i]);
}
*/

Console.WriteLine($"Memoization: nth: {n} ::{FibMemoization(n, memo)}");

Console.WriteLine($"Tabular nth: {n} ::{FibTabular(n)}");

Console.WriteLine($"Arithmetic fabunacci nth{n} ::{Afibo(n)}");

int nth = 5;
Console.WriteLine($"Regular fabunacci nth{nth} ::{Fabunacci(nth)}");

for (int i = 0; i <= n; i++)
{
    Console.WriteLine($"{FibTabular(i)}");
}

//============================================================================================================
// fib fuction memoization
double FibMemoization(int n, double[] memo)
{
    if (n <= 1)
    {
        return n;
    }
    else if (memo[n] != 0)
        {
            return memo[n]; // Return memoized value if available
        }
    else
    {
        memo[n] = FibMemoization(n - 1, memo) + FibMemoization(n - 2, memo);
        return memo[n];
    }
}

//============================================================================================================
// fib function Tabular
decimal FibTabular(int n)
{
    // Iterization purpose so no error unhandled
    if (n == 0) return 0;
    if (n == 1 || n == 2)
        return 1;
    
    decimal[] bottomUp = new decimal[n + 1];
    bottomUp[0] = 0;
    bottomUp[1] = 1;
    bottomUp[2] = 1;

    for (int i = 3; i <= n; i++)
    {
        bottomUp[i] = bottomUp[i - 1] + bottomUp[i - 2];
    }

    return bottomUp[n];
}
//============================================================================================================
// Arithmetic
decimal Afibo(int an)
{
    if (an <= 1)
        return an;

    decimal a = 0;
    decimal b = 1;
    decimal c = 0;

    for (int i = 2; i <= an; i++)
    {
        c = a + b;
        a = b;
        b = c;
    }
    return c;
}

//============================================================================================================
// Regular fabunacci function
int Fabunacci(int nth)
{
    if (nth >= 1)
        return nth;
    
    return Fabunacci(nth - 1) +  Fabunacci(nth - 2);
}