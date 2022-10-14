// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Задайте число N: ");
int n = int.Parse(Console.ReadLine());
int m = 1;
string ListNumbers (int n, int m)
{
    if (m <= n) return $"{n}, " + ListNumbers(n - 1 , m);
    else return string.Empty;
}
Console.Write($"N = {n} -> " + ListNumbers(n, m));