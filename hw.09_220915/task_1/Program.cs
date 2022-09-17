string task_name = @"Задача 1
Задайте двумерный массив.
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2";
int separator_length = 120;
string separator = new String('#', separator_length);
Console.Clear();
Console.WriteLine(separator);
Console.WriteLine("\n" + task_name + "\n");
Console.WriteLine(separator);
Console.WriteLine("");

void WriteColorMessage(int type, string message)
{
    if (type == 0)
    {
        // Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.ForegroundColor = ConsoleColor.DarkRed;
    }
    else if (type == 1)
    {
        Console.BackgroundColor = ConsoleColor.DarkGreen;
    }
    else if (type == 2)
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Black;
    }
    else if (type == 3)
    {
        Console.BackgroundColor = ConsoleColor.Blue;
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.DarkYellow;
    }
    Console.WriteLine($" {message} ");
    Console.ResetColor();
}

Random rnd = new Random();
void ArrayFilling2D(int[,] array, int rndNumbStart, int rndNumbStop)
// Заполнение массива случайными данными
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(rndNumbStart, rndNumbStop);
        }
    }
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


string[] paramArray = new string[2];
Console.Write("Введите, через пробел, размер двумерного массива (строки и столбцы): ");
paramArray = Console.ReadLine().Split(' ');
int row = int.Parse(paramArray[0]);
int col = int.Parse(paramArray[1]);

int[,] numbers = new int[row, col];

string[] arrayRandomParam = new string[2];
anchorRandomParam:
Console.Write("Введите, целые числа через пробел, интервал для рандомизации чисел (начальное и конечное): ");
arrayRandomParam = Console.ReadLine().Split(' ');
int rndNumbStart = int.Parse(arrayRandomParam[0]);
int rndNumbStop = int.Parse(arrayRandomParam[1]);
Console.WriteLine($"Создан интервал для рандомизации целых чисел [{rndNumbStart}, {rndNumbStop}]");
if ((rndNumbStop < rndNumbStart))
{
    WriteColorMessage(0, $"Числа для генерации не верны, начальное число {rndNumbStart} больше конечного числа {rndNumbStop}.");
    goto anchorRandomParam;
}

ArrayFilling2D(numbers, rndNumbStart, rndNumbStop);
ArrayDisplay2D(numbers);


void ArraySortLine(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = array.GetLength(1) - 1; k > j; k--)
            {
                if (array[i, k] > array[i, k - 1])
                {
                    int tmp = array[i, k];
                    array[i, k] = array[i, k - 1];
                    array[i, k - 1] = tmp;
                }
            }
            // Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

ArraySortLine(numbers);
ArrayDisplay2D(numbers);