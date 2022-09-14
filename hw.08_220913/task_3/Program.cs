string task_name = @"Задача 3.
Сформируйте двухмерный массив из неповторяющихся двузначных чисел (размер массива не более 50 элементов). 
Напишите программу, которая будет построчно выводить массив.
Вариант создания функции:
Проверить число на присутствие в массиве (bool Contains(int[,] arr, int value){...} )
Пример:
Массив размером 3 x 3
10 11 55
33 41 23
17 28 34";
int separator_length = 120;
string separator = new String('#', separator_length);
Console.Clear();
Console.WriteLine(separator);
Console.WriteLine("\n" + task_name + "\n");
Console.WriteLine(separator);
Console.WriteLine("");

Random rnd = new Random();
int GetRandomNumber(int start, int stop)
{
    int number = rnd.Next(start, stop);
    // Console.Write($"{number} ");
    return number;
}

int FoundNumber(int[,] array, int numb)
{
    int countRepeatNumb = 0;
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            if (array[m, k] == numb)
            {
                countRepeatNumb++;
            }
        }
    }
    return countRepeatNumb;
}

void ArrayDisplay2D(int[,] array)
{
    // вывод содержимого двумерного (матричного, табличного) массива
    Console.WriteLine($"Содержимое двумерного массива c данными:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int row = 4, col = 12;

int[,] numbers = new int[row, col];
Console.WriteLine($"Создан двумерный массив [{row},{col}]");


for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        int newNumb = GetRandomNumber(1, 51);
        int numberRepeatCount = FoundNumber(numbers, newNumb);
        if (numberRepeatCount > 0)
        {
            j -= 1;
        }
        else
        {
            numbers[i, j] = newNumb;
        }
    }
}

Console.WriteLine("\n");
ArrayDisplay2D(numbers);