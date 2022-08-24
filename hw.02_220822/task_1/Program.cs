string task_name = "Напишите программу, которая принимает на вход случайно сгенерированное трёхзначное число и на выходе показывает вторую цифру этого числа.";
int separator_length = 120;
string separator = new String ('#', separator_length);
Console.Clear();
Console.WriteLine(separator);
Console.WriteLine("\n" + task_name + "\n");
Console.WriteLine(separator);
Console.WriteLine("");

int random_digit = new Random().Next(100, 999);
Console.WriteLine("Случайно сгенерированное трехзначное число: " + random_digit);

int digit_1 = random_digit / 100;
// Console.WriteLine(digit_1);

int digit_2 = random_digit - digit_1 * 100;
// Console.WriteLine(digit_2);

int digit_3 = digit_2 / 10;
// Console.WriteLine(digit_3);

int result = (random_digit - (random_digit / 100) * 100) / 10;
Console.Write("ОТВЕТ: ");
Console.WriteLine("Для числа " + random_digit + " вторая цифра является " + result + ".\n\n");