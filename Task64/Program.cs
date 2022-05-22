// Задача 64: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9



int SumNumber(int num, int sum = 0)
{
    if(num > 0)
    {
        sum = sum + num % 10;
        num /= 10;
        return SumNumber(num, sum);
    }
    else return sum;
}

Console.WriteLine(SumNumber(453));