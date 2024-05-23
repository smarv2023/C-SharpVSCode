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

 Console.WriteLine($"Memoization: nth: {n} ::{fibMemoization(n, memo)}");

 Console.WriteLine($"Tabular nth: {n} ::{fibTabular(n)}");

int nth = 5;
 Console.WriteLine($"Regular fabunacci nth{nth} ::{fabunacci(nth)}");

//============================================================================================================
// fib fuction memoization
double fibMemoization(int n, double[] memo)
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
        memo[n] = fibMemoization(n - 1, memo) + fibMemoization(n - 2, memo);
        return memo[n];
    }
}

//============================================================================================================
// fib function Tabular
double fibTabular(int n)
{
    if (n == 1 || n == 2)
    {
        return 1;
    }

    double[] bottomUp = new double[n + 1];
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
// Regular fabunacci function
int fabunacci(int nth)
{
    if (nth >= 1)
        return nth;
    
    return fabunacci(nth - 1) +  fabunacci(nth - 2);

    
}