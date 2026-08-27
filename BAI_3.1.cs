using System;

Console.Write("Nhap so a: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Nhap so b: ");
double b = double.Parse(Console.ReadLine());

Console.Write("Nhap phep toan (+, -, *, /, %): ");
char op = char.Parse(Console.ReadLine());

try
{
    double result = op switch
    {
        '+' => a + b,
        '-' => a - b,
        '*' => a * b,
        '/' => a / b,
        '%' => a % b,
        _ => 0
    };

    if ((op == '/' || op == '%') && b == 0)
    {
        Console.WriteLine("Loi: Khong the chia cho 0!");
    }
    else
    {
        Console.WriteLine("Ket qua: " + result.ToString("F2"));
    }
}
catch
{
    Console.WriteLine("Loi: Du lieu khong hop le!");
}