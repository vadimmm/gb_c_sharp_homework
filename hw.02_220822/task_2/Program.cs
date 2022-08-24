string task_name = "Задача 2: Напишите программу, которая выводит третью цифру случайно сгенерированного числа (от 1 до 65536) или сообщает, что третьей цифры нет.";
int separator_length = 120;
string separator = new String ('#', separator_length);
Console.Clear();
Console.WriteLine(separator);
Console.WriteLine("\n" + task_name + "\n");
Console.WriteLine(separator);
Console.WriteLine("");

int random_digit = new Random().Next(1, 65536); //65536
Console.WriteLine("Случайно сгенерированное число: " + random_digit);

int result = 0;

Console.Write("ОТВЕТ: ");
if (random_digit <= 99)
{
    Console.WriteLine("У числа " + random_digit + " третьей цифры нет.");
}
else
{
    if ((random_digit >= 100) && (random_digit <= 999))
    {
        result = random_digit / 10;
    }
    else if ((random_digit >= 1000) && (random_digit <= 9999))
    {
        result = (random_digit / 10) % 10;
    }
    else if ((random_digit >= 10000) && (random_digit <= 99999))
    {
        result = (random_digit / 100) % 10;
    }
    Console.WriteLine("У числа " + random_digit + " третья цифра является " + result + ".\n\n");
}