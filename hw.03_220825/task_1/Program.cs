string task_name = @"Задача 1
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Число хранить в типе данных int, решать с помощью арифметических операций
(не рассматривая число как тип данных string).";
int separator_length = 120;
string separator = new String ('#', separator_length);
Console.Clear();
Console.WriteLine(separator);
Console.WriteLine("\n" + task_name + "\n");
Console.WriteLine(separator);
Console.WriteLine("");

Console.Write("Пожалуйста, введите целое число: ");
int value = Convert.ToInt32(Console.ReadLine());
int value_reverse = 0;
int value_temp = value;

// решение методом цикла while
while (value_temp != 0)
{
    int value_last = value_temp % 10;
    value_reverse = value_reverse * 10 + value_last;
    value_temp = value_temp / 10;
}

if (value == value_reverse)
{
    Console.BackgroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(" Число является палиндромом ");
    Console.ResetColor();
}
else
{
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(" Число не является палиндромом ");
    Console.ResetColor();
}