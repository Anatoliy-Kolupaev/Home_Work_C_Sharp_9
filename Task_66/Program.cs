﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Задайте число M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте число N: ");
int n = int.Parse(Console.ReadLine());
int k = m;
if (m > n)
{
    m = n; 
    n = k;
}
int Sum (int m, int n)
{
    if (n <= m) return m;
    else  return m + Sum (m + 1, n);
}

int sum = Sum (m, n);
Console.WriteLine($"Сумму натуральных элементов в промежутке от {m} до {n} = {sum}");