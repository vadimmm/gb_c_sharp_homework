string task_name = @"Задача 2: 
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2, значения b1, k1, b2 и k2 задаются пользователем.
Рекомендую учесть три возможных случая расположения двух прямых.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)";
int separator_length = 120;
string separator = new String('#', separator_length);
Console.Clear();
Console.WriteLine(separator);
Console.WriteLine("\n" + task_name + "\n");
Console.WriteLine(separator);
Console.WriteLine("");

int b1 = 2, k1 = 5, b2 = 4, k2 = 9;

// int [] lineCoordinates = new int[4];

// string [] lineCoordinates = Console.ReadLine().Split(' ').Select(Convert.ToInt32).ToArray();



double x = ((b2 - b1) / (k1 - k2));
Console.WriteLine("x = " + x);

double y = (k1 * x) + b1;
Console.WriteLine("y = " + y);

if ((b1 * k2 - b2 * k1) == 0)
{
    Console.WriteLine("Паралельно");
}
else if ((b1 * b2 + k1 * k2) == 0)
{
    Console.WriteLine("Перпендикулярны");
}
else
{
    Console.WriteLine($"Координаты пересечения x = {x}; y = {y}");
}