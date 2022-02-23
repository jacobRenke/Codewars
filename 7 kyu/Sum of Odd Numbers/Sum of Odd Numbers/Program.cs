// See https://aka.ms/new-console-template for more information

long n = 2;
Console.WriteLine(rowSumOddNumbers(n));


static long rowSumOddNumbers(long n)
{
    long result = 0;

    //loop for how many times I need to go through pyramid
    //long iterations = 0;
    //for (int i = 1; i <= n * n - 1; i += 2)
    //{
    //    iterations += i;
    //}



    //if (n == 1)
    //    return 1;

    //for (long j = 1; j < iterations; j += 2)
    //{
    //    result += j;
    //}

    //return result;

    result = (n * n) * n;
    return result;
}