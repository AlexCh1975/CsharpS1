/*
    Напишите программу, которая на вход принимает два числа и проверяет, 
    является ли первое число квадратом второго. 
    a = 25, b = 5 -> да 
    a = 2, b = 10 -> нет 
    a = 9, b = -3 -> да 
    a = -3 b = 9 -> нет
*/

Console.Clear();

void SqrtNumbers(int a, int b)
{
    if (b * b == a) 
    {
        Console.WriteLine($"{a} является квадратом {b} ? -> да");
    }
    else
    {
        Console.WriteLine($"{a} является квадратом {b} ? -> нет");
    }
}

SqrtNumbers(25, 5);
SqrtNumbers(2, 10);
SqrtNumbers(9, -3);
SqrtNumbers(-3, 9);