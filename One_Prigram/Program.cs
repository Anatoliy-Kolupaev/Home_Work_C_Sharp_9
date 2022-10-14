System.Console.WriteLine("Добрый день!");
int n = 0;
int v = 100;
while (n < v)
{
    Console.Write("Выберите задачу которую хотите проверить (задачи пронумерованы 64, 66, 68,):  ");
    int choice = int.Parse(Console.ReadLine());
    while (choice == 64)
    {
        Console.WriteLine();
        Console.WriteLine("Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.");
        Console.WriteLine();
        if (choice == 64) task64();
        if (choice == 64) task64();
        if (choice == 64) task64();
        break;

    }
    while (choice == 66)
    {
        Console.WriteLine();
        Console.WriteLine("Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
        Console.WriteLine();
        if (choice == 66) task66();
        if (choice == 66) task66();
        if (choice == 66) task66();
        break;
    }
    while (choice == 68)
    {
        Console.WriteLine();
        Console.WriteLine("Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
        Console.WriteLine();
        if (choice == 68) task68();
        if (choice == 68) task68();
        if (choice == 68) task68();
        break;
    }
    n++;
}

void task64()
{
    Console.WriteLine("Задайте число N: ");
    int n = int.Parse(Console.ReadLine());
    int m = 1;
    string ListNumbers(int n, int m)
    {
        if (m <= n) return $"{n}, " + ListNumbers(n - 1, m);
        else return string.Empty;
    }
    Console.Write($"N = {n} -> " + ListNumbers(n, m));
}

void task66()
{
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
    int Sum(int m, int n)
    {
        if (n <= m) return m;
        else return m + Sum(m + 1, n);
    }

    int sum = Sum(m, n);
    Console.WriteLine($"Сумму натуральных элементов в промежутке от {m} до {n} = {sum}");
}
void task68()
{
    Console.WriteLine("Задайте число m: ");
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine("Задайте число n: ");
    int n = int.Parse(Console.ReadLine());

    int functionAkkerman = Ackerman(m, n);
    Console.Write($"Функция Аккермана A(m,n) = {functionAkkerman} ");

    int Ackerman(int m, int n)
    {
        if (m == 0) return n + 1;
        else if (n == 0) return Ackerman(m - 1, 1);
        else return Ackerman(m - 1, Ackerman(m, n - 1));
    }

}
