string task_name = @"Задача 1.
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
example: [345, 897, 568, 234] -> 2";
int separator_length = 120;
string separator = new String('#', separator_length);
Console.Clear();
Console.WriteLine(separator);
Console.WriteLine("\n" + task_name + "\n");
Console.WriteLine(separator);
Console.WriteLine("");

// Базовые переменные
int numbStart = 100;
int numbStop = 999;
int N = numbStop + 1 - numbStart;
int sum = 0;

// Создание массива array
int[] array = new int[N];

for (int i = 0; i < N; i++)
{
    array[i] = i + numbStart;
    Console.WriteLine($"{array[i]} ");
}

for(int i = 0; i < N; i++)
{
    if (array[i] % 2 == 0)
    {
        Console.WriteLine($"{array[i]} ");
        sum++;
    }
}

Console.WriteLine($"ОТВЕТ: В массиве найдено {sum} четных чисел.");