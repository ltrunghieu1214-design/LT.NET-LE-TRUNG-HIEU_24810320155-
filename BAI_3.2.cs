using System;

Console.Write("Nhap a: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Nhap b: ");
double b = double.Parse(Console.ReadLine());

Console.Write("Nhap c: ");
double c = double.Parse(Console.ReadLine());

if (a == 0)
{
    // Phuong trinh bac nhat: bx + c = 0
    if (b == 0)
    {
        if (c == 0)
            Console.WriteLine("Vo so nghiem");
        else
            Console.WriteLine("Vo nghiem");
    }
    else
    {
        double x = -c / b;
        Console.WriteLine("Nghiem x = " + x.ToString("F2"));
    }
}
else
{
    // Phuong trinh bac 2
    double delta = b * b - 4 * a * c;

    if (delta < 0)
    {
        Console.WriteLine("Vo nghiem");
    }
    else if (delta == 0)
    {
        double x = -b / (2 * a);
        Console.WriteLine("Nghiem kep x = " + x.ToString("F2"));
    }
    else
    {
        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

        Console.WriteLine("x1 = " + x1.ToString("F2"));
        Console.WriteLine("x2 = " + x2.ToString("F2"));
    }
}