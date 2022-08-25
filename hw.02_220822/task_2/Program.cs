string task_name = "Задача 2: Напишите программу, которая выводит третью цифру случайно сгенерированного числа (от 1 до 65536) или сообщает, что третьей цифры нет.";
int separator_length = 120;
string separator = new String ('#', separator_length);
Console.Clear();
Console.WriteLine(separator);
Console.WriteLine("\n" + task_name + "\n");
Console.WriteLine(separator);
Console.WriteLine("");

// int random_digit = new Random().Next(1, 65536); //65536
// int random_digit = new Random().Next(65536, 99999999); //65536
int random_digit = new Random().Next(1, 2147483647);
Console.WriteLine("Случайно сгенерированное число: " + random_digit);

// int result = 0;

Console.Write("ОТВЕТ: ");
if (random_digit <= 99)
{
    Console.WriteLine("У числа " + random_digit + " третьей цифры нет.");
}
else if (random_digit >= 100) 
{
    // не придумал, но применил успешно
    string str = random_digit.ToString();
    int[] result = new int[str.Length];
    for( int i=0; i< str.Length; i++)
    {
        result[i] = int.Parse(str[i].ToString());
    }
    Console.WriteLine("У числа " + random_digit + " третья цифра является " + result[2] + ".\n\n");
}