string task_name = @"Задача 1: 
Задайте двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка";
int separator_length = 120;
string separator = new String('#', separator_length);
Console.Clear();
Console.WriteLine(separator);
Console.WriteLine("\n" + task_name + "\n");
Console.WriteLine(separator);
Console.WriteLine("");

string [] paramArray = new string[2];
Console.Write("Введите, через пробел, размер двумерного массива (строки и столбцы): ");
paramArray  = Console.ReadLine().Split(' ');
int row = int.Parse(paramArray[0]);
int col = int.Parse(paramArray[1]);

// int row = 8;
// int col = 2;

int[,] numbers = new int[row, col];

// заполнение массива случайными числами
Random rnd = new Random();
int rndNumbStart = 0;
int rndNumbStop = 9;
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[i, j] = rnd.Next(rndNumbStart, rndNumbStop);
    }
}

void ShowArray1D(int[] array)
{
    // вывод содержимого одномерного массива
    Console.WriteLine("\nСодержимое одномерного массива c данными:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]}\t");
    }
    Console.WriteLine();
}

void ShowArray2D(int[,] array)
{
    // вывод содержимого двумерного (матричного, табличного) массива
    Console.WriteLine("\nСодержимое двумерного массива c данными:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[] summArray = new int[row];

int sum = 0;
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sum+= numbers[i, j];
    }
    Console.WriteLine();
    summArray[i] = sum;
    sum = 0;
}

ShowArray2D(numbers);

ShowArray1D(summArray);



int minNumb = summArray[0];
for(int m = 0; m < summArray.GetLength(0); m++)
{
    if (minNumb > summArray[m])
    {
        minNumb = summArray[m];
    }
}

// подсчёт количества повторяющихся цифр
string minIndex = "";
int indexCount = 0; 
for(int s = 0; s < summArray.GetLength(0); s++)
{
    if (summArray[s] == minNumb)
    {
        indexCount++;
        minIndex = minIndex + " [" + s.ToString() + "]"; 
    }
}

Console.Write($"\nОТВЕТ: ");
if (indexCount == 1)
{
    Console.WriteLine($"Минимальная сумма {minNumb} найдена, индекс в массиве{minIndex}.");
}
else
{
    Console.WriteLine($"Найдено {indexCount} минимальных значения суммы {minNumb} с индексами в массиве{minIndex}.");
}