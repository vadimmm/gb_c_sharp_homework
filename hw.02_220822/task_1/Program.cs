string task_name = "Задача 1. Напишите программу, которая принимает на вход случайно сгенерированное трёхзначное число и на выходе показывает вторую цифру этого числа.";
int separator_length = 120;
string separator = new String ('#', separator_length);
Console.Clear();
Console.WriteLine(separator);
Console.WriteLine("\n" + task_name + "\n");
Console.WriteLine(separator);
Console.WriteLine("");

int random_digit = new Random().Next(100, 999);
Console.WriteLine("Случайно сгенерированное трехзначное число: " + random_digit);

int result = (random_digit - (random_digit / 100) * 100) / 10;
Console.Write("ОТВЕТ: ");
Console.WriteLine("Для числа " + random_digit + " вторая цифра является " + result + ".\n\n");