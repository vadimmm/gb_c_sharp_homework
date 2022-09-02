﻿string task_name = @"Задача 3 (Дополнительная).
Задайте массив натуральных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76";
int separator_length = 120;
string separator = new String('#', separator_length);
Console.Clear();
Console.WriteLine(separator);
Console.WriteLine("\n" + task_name + "\n");
Console.WriteLine(separator);
Console.WriteLine("");

Console.Write("Введите количество чисел для участия в проверке: ");
int N = Convert.ToInt32(Console.ReadLine());

int numbStart = -2147483648;
int numbStop = 2147483647;

int[] numbers = new int[N];

Random rnd = new Random();

for (int i = 0; i < N; i++)
{
    numbers[i] = rnd.Next(numbStart, numbStop);
}


void MinMaxArrayNumbers(string value)
int numb = numbers[0];
{
    if (value == "min")
    {
        for(int i=0; i < N;i++)
        {
            if (numb < numbers[i])
            {
               numb = numbers[i];
            }
        }
    }
    else if (value == "max")
    {
        for(int i=0; i < N;i++)
        {
            if (numb > numbers[i])
            {
               numb = numbers[i];
            }   
        }
    }
    else
    {
        Console.Write("Не верные входные данные...");
        return;
    }
    return numb;
}

int numbMin = MinMaxArrayNumbers("min");
int numbMax = MinMaxArrayNumbers("max");

int result = numbMax - numbMin;
Console.WriteLine($"ОТВЕТ: Разница между максимальным {numbMax} и минимальным {numbMin} значение массива сосставляет {result}.");