string task_name = "Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).";
int separator_length = 123;
string separator = new String ('#', separator_length);
Console.Clear();
Console.WriteLine(separator);
Console.WriteLine("\n" + task_name + "\n");
Console.WriteLine(separator);
Console.WriteLine("");

Console.Write("Пожалуйста, введите целое число: ");
int numb = Convert.ToInt32(Console.ReadLine());

Console.Write("ОТВЕТ: ");
if (numb % 2 == 0)
{
    Console.WriteLine("Да, число " + numb + " является чётным.");
}
else
{
    Console.WriteLine("Нет, число " + numb + " является нечётным.");
}