// See https://aka.ms/new-console-template for more information

int n = 24;
Console.WriteLine(Fib(n));

static int Fib(int n)
{
    int f1 = 0, f2 = 1, f3 = 0;
    for (int i = 2; i < n + 1; i++)
    {
        f3 = f1 + f2;
        f1 = f2;
        f2 = f3;
    }
    return f3;
}