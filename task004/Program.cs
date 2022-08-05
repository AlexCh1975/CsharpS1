/*
   Напишите программу, которая на вход принимает одно число (N), 
   а на выходе показывает все целые числа в промежутке от -N до N. 
   4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
   2 -> " -2, -1, 0, 1, 2" 
*/

Console.Clear();

void IntNumbers(int num)
{
    Console.Write($"{num} -> ");
    for(int i = -num; i <= num; i++)
    {
        Console.Write($"{i}, ");
    }
    Console.WriteLine(" ");
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

IntNumbers(num);
