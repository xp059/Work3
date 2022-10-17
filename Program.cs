/*
// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool IsThisPalindromeNumberFirstB(int num)
{
    bool res = true;
    while (num > 9)
    {
        int lastDigit = num % 10;
        int firstDigit = num;
        int countOfDigits = 0;
        while (firstDigit >= 10)
        {
            countOfDigits++;
            firstDigit /= 10;
        }
        if (lastDigit != firstDigit)
        {
            res = false;
            break;
        }
        num = num / 10 % (Convert.ToInt32(Math.Pow(10, countOfDigits - 1)));
    }
    return res;
}

Console.Write("Введите число, которое будем проверять на палиндром: ");
int number = Convert.ToInt32(Console.ReadLine());

bool palindromeNumber = IsThisPalindromeNumberFirstB(number);

if (palindromeNumber)
    Console.WriteLine($"Число {number} является палиндромом.");
else
    Console.WriteLine($"Число {number} НЕ является палиндромом.");
*/

/*
// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double FindDistance(double ax, double ay, double az, double bx, double by, double bz)
{
    return Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));
}
Console.Write("Введите коордитану X точки A: ");
double ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коордитану Y точки A: ");
double ay = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коордитану Z точки A: ");
double az = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Точка A будет иметь координаты ({ax}, {ay}, {az}).");
Console.Write("Введите коордитану X точки B: ");
double bx = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коордитану Y точки B: ");
double by = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коордитану Z точки B: ");
double bz = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Точка B будет иметь координаты ({bx}, {by}, {bz}).");
Console.WriteLine($"Расстояние между точкой A({ax}, {ay}, {az}) и точкой B({bx}, {by}, {bz}) примерно равно равно {Math.Round(FindDistance(ax, ay, az, bx, by, bz), 2)}.");
*/

/*
// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void QuartsOfNumbersB(int n)
{
    int count = 1;
    int tableSide = Convert.ToInt32(Math.Sqrt(n));
    while (count <= n)
    {
        Console.Write($"{Math.Pow(count, 3)} ");
        // if (count < n) Console.Write(", ");
        if (count % tableSide == 0) Console.WriteLine();
        count++;
    }
}
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
QuartsOfNumbersB(n); // в виде таблицы
*/