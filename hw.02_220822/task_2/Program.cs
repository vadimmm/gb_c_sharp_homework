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

string digit_len = Convert.ToString(random_digit);
// Console.WriteLine(digit_len.Length);


Console.Write("ОТВЕТ: ");
int result = 0;
// string print_result_345 = ("У числа " + random_digit + " третья цифра является " + result + ".\n\n");


if (digit_len.Length <= 2)
{
    Console.WriteLine("У числа " + random_digit + " третьей цифры нет.");
}
else
{
    if (digit_len.Length == 3)
        {
            int result = random_digit - ((random_digit / 10) * 10);
        }
    else if (digit_len.Length == 4)
        {
            int result = (random_digit - ((random_digit / 100) * 100)) / 10;
        }
    // else if (digit_len.Length == 5)
    //     {
    //         int result = (random_digit - ((random_digit / 1000) * 1000)) / 100;
    //     }
    Console.WriteLine("У числа " + random_digit + " третья цифра является " + result + ".\n\n");
}