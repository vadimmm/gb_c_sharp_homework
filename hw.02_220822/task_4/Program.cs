string task_name = "Задача 4: Напишите программу, которая принимает на вход случайно сгенерированное число (от 1 до 1 000 000) и проверяет, кратно ли оно одновременно 7 и 23.";
int separator_length = 120;
string separator = new String ('#', separator_length);
Console.Clear();
Console.WriteLine(separator);
Console.WriteLine("\n" + task_name + "\n");
Console.WriteLine(separator);
Console.WriteLine("");

int random_digit = new Random().Next(1, 1000000);
// int random_digit = new Random().Next(160, 162);
Console.WriteLine("Случайно сгенерированное число: " + random_digit);
int denominator_1 = 7, denominator_2 = 23;

if ((random_digit % denominator_1) == 0 && (random_digit % denominator_2) == 0)
{
    Console.BackgroundColor = ConsoleColor.DarkGreen;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine($" Число {random_digit} кратно числам {denominator_1} и {denominator_2} ");
    Console.ResetColor();
}
else
{
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($" Число {random_digit} не кратно числам {denominator_1} и {denominator_2} ");
    Console.ResetColor();
}
