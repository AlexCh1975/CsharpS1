/*
    Демонстрация решения Напишите программу, которая на вход принимает 
    число и выдаёт его квадрат (число умноженное на само себя)
    4 ->16
    -3 -> 9
    -7 -> 49
*/

Console.Clear();

int userNumber = new int();
Console.WriteLine("Введите число: ");
userNumber = Convert.ToInt32(Console.ReadLine());

int result = userNumber * userNumber;

Console.WriteLine($"Чило {userNumber} в квадрате = {result}");
