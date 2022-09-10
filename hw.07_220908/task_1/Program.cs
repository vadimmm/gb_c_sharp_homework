string task_name = @"Задача 1.
Задайте двумерный массив размером MxN, заполненный случайными вещественными (тип double) числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9";
int separator_length = 120;
string separator = new String('#', separator_length);
Console.Clear();
Console.WriteLine(separator);
Console.WriteLine("\n" + task_name + "\n");
Console.WriteLine(separator);
Console.WriteLine("");

Console.Write("Введите число строк массива: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int N = Convert.ToInt32(Console.ReadLine());

// int M = 5;
// int N = 4;

// коэфицент для получения случайных десятичных
double k = 10.0;

double[,] numbers = new double[M, N];

// заполнение массива случайными числами
Random rnd = new Random();
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[i, j] = rnd.Next(-100, 100) / k;
    }
}

// вывод содержимого массива
Console.Write("\n\nОТВЕТ. ");
Console.WriteLine("Содержимое массива после заполнения случайными данными:");
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        Console.Write($"{numbers[i, j]}\t");
    }
    Console.WriteLine("");
}