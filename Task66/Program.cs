﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



int SumNumbers(int m, int n, int sum = 0)
{
    if (m <= n)
    {
        sum = sum + m;
        m++;
        return SumNumbers(m, n, sum);
    }
    else return sum;
}

Console.WriteLine(SumNumbers(1, 15));