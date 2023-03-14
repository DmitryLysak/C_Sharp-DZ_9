// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;
using static System.Console;

Clear();
Write("Введите число M: ");
int m = int.Parse(ReadLine()!);
Write("Введите число N: ");
int n = int.Parse(ReadLine()!);
int sum = 0;

void SumNumber (int m, int n, int sum)
{
    if (m > n) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N -> {sum}"); 
        return;
    }
    sum = sum + (m++);
    SumNumber(m, n, sum);
}

SumNumber(m, n, sum);