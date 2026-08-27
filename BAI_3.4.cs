using System;

int choice;

do
{
    Console.Clear();

    Console.WriteLine("===== MENU =====");
    Console.WriteLine("1. Chay Bai tap 1 - Calculator");
    Console.WriteLine("2. Chay Bai tap 2 - Phuong trinh bac 2");
    Console.WriteLine("3. Chay Bai tap 3 - So nguyen to & Fibonacci");
    Console.WriteLine("0. Thoat chuong trinh");
    Console.WriteLine("================");

    Console.Write("Nhap lua chon: ");
    choice = int.Parse(Console.ReadLine());

    Console.Clear();

    switch (choice)
    {
        case 1://BAI TAP 3.1
            Console.WriteLine("=== BAI TAP 1: CALCULATOR ===");

            Console.Write("Nhap a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhap b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhap phep toan (+, -, *, /, %): ");
            char op = char.Parse(Console.ReadLine());

            if ((op == '/' || op == '%') && b == 0)
            {
                Console.WriteLine("Loi: Khong the chia cho 0!");
            }
            else
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

                Console.WriteLine("Ket qua: " + result.ToString("F2"));
            }

            break;
        //BAI TAP 3.2
        case 2:
            Console.WriteLine("=== BAI TAP 2: PHUONG TRINH BAC 2 ===");

            Console.Write("Nhap a: ");
            double a2 = double.Parse(Console.ReadLine());

            Console.Write("Nhap b: ");
            double b2 = double.Parse(Console.ReadLine());

            Console.Write("Nhap c: ");
            double c2 = double.Parse(Console.ReadLine());

            if (a2 == 0)
            {
                if (b2 == 0)
                {
                    if (c2 == 0)
                        Console.WriteLine("Vo so nghiem");
                    else
                        Console.WriteLine("Vo nghiem");
                }
                else
                {
                    double x = -c2 / b2;
                    Console.WriteLine("Nghiem x = " + x.ToString("F2"));
                }
            }
            else
            {
                double delta = b2 * b2 - 4 * a2 * c2;

                if (delta < 0)
                {
                    Console.WriteLine("Vo nghiem");
                }
                else if (delta == 0)
                {
                    double x = -b2 / (2 * a2);
                    Console.WriteLine("Nghiem kep x = " + x.ToString("F2"));
                }
                else
                {
                    double x1 = (-b2 + Math.Sqrt(delta)) / (2 * a2);
                    double x2 = (-b2 - Math.Sqrt(delta)) / (2 * a2);

                    Console.WriteLine("x1 = " + x1.ToString("F2"));
                    Console.WriteLine("x2 = " + x2.ToString("F2"));
                }
            }

            break;
        //BAI TAP 3.3
        case 3:
            Console.WriteLine("=== BAI TAP 3: SO NGUYEN TO & FIBONACCI ===");

            Console.Write("Nhap N: ");
            int N = int.Parse(Console.ReadLine());

            // Kiem tra so nguyen to
            bool isPrime = true;

            if (N < 2)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i < N; i++)
                {
                    if (N % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
                Console.WriteLine(N + " la so nguyen to!");
            else
                Console.WriteLine(N + " KHONG la so nguyen to!");

            // Kiem tra so hoan hao
            int sum = 0;

            for (int i = 1; i < N; i++)
            {
                if (N % i == 0)
                    sum += i;
            }

            if (sum == N)
                Console.WriteLine(N + " la so hoan hao!");
            else
                Console.WriteLine(N + " KHONG la so hoan hao!");

            // Fibonacci
            Console.Write("Day Fibonacci " + N + " so: ");

            int f1 = 0;
            int f2 = 1;

            for (int i = 0; i < N; i++)
            {
                Console.Write(f1);

                if (i < N - 1)
                    Console.Write(", ");

                int f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
            }

            Console.WriteLine();

            break;

        case 0:
            Console.WriteLine("Da thoat chuong trinh!");
            break;

        default:
            Console.WriteLine("Lua chon khong hop le!");
            break;
    }

    if (choice != 0)
    {
        Console.WriteLine();
        Console.WriteLine("Nhan phim bat ky de quay lai Menu...");
        Console.ReadKey();
    }

} while (choice != 0);