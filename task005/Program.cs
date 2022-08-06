/*
    Напишите программу, которая принимает на вход трёхзначное число 
    и на выходе показывает последнюю цифру этого числа. 
    456 -> 6 
    782 -> 2 
    918 -> 8
*/

Console.Clear();

// void TransformNumber(string num)
// {
//     char[] numbers = num.ToCharArray();
//     for (int i = 0; i <= numbers.Length - 1; i++)
//     {
//         if (i == numbers.Length -1) Console.WriteLine($"Последняя цифра числа {num}: {numbers[i]}");
//     } 
// }

// Console.Write("Введите число: ");
// string num = Console.ReadLine();
// TransformNumber(num);

void TransformNumber(int number)
{
    int num = number % 10;
    Console.WriteLine($"Последняя цифра числа {number}: {num}");
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
TransformNumber(number);
