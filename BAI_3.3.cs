using System;

Console.Write("Nhap N: ");
int N = int.Parse(Console.ReadLine());

// Kiem tra so nguyen to
bool IsPrime(int n)
{
    if (n < 2)
        return false;

    for (int i = 2; i < n; i++)
    {
        if (n % i == 0)
            return false;
    }

    return true;
}

// Kiem tra so hoan hao
bool IsPerfectNumber(int n)
{
    int sum = 0;

    for (int i = 1; i < n; i++)
    {
        if (n % i == 0)
            sum += i;
    }

    return sum == n;
}

// Kiem tra so nguyen to
if (IsPrime(N))
    Console.WriteLine(N + " la So nguyen to!");
else
    Console.WriteLine(N + " KHONG la So nguyen to!");

// Kiem tra so hoan hao
if (IsPerfectNumber(N))
    Console.WriteLine(N + " la So hoan hao!");
else
    Console.WriteLine(N + " KHONG la So hoan hao!");

// In day Fibonacci
Console.Write("Day Fibonacci " + N + " so: ");

int a = 0;
int b = 1;

for (int i = 0; i < N; i++)
{
    Console.Write(a);

    if (i < N - 1)
        Console.Write(", ");

    int c = a + b;
    a = b;
    b = c;
}