/*
 Напишите программу, которая будет выдавать название дня недели 
 по заданному номеру. 3 -> Среда 5 -> Пятница   
*/

Console.Clear();

void DayOfTheWeek(int day)
{
    string[] week = {"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресение"};

    if (day > 7 || day == 0) Console.WriteLine("Такого дня недели не существует!");

    for (int i = 0; i <= week.Length - 1; i++ ) 
    {
        if (day-1 == i) 
        {
            Console.WriteLine($"{day} -> {week[i]}");
        }
    }
}


Console.Write("Введите номе дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

DayOfTheWeek(day);
