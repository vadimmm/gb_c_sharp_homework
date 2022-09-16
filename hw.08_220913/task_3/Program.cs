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

string[] arrayParam = new string[2];
Console.Write("Введите, через пробел, размер используемых двумерных массивов (строки и столбцы): ");
arrayParam = Console.ReadLine().Split(' ');
int row = int.Parse(arrayParam[0]);
int col = int.Parse(arrayParam[1]);
Console.WriteLine("");
// int row = 4, col = 12;

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
else if ((row * col) >= (rndNumbStop + 1 - rndNumbStart))
{
    WriteColorMessage(0, $"Введённый интервал {rndNumbStop - rndNumbStart} слишком мал для генерации уникальных числел для массива размером {row * col}.");
    goto anchorRandomParam;
}

int[,] numbers = new int[row, col];
Console.WriteLine($"Создан двумерный массив [{row},{col}]");

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        int rndNumber = GetRandomNumber(rndNumbStart, rndNumbStop + 1);
        int numberRepeatCount = FoundNumber(numbers, rndNumber);
        if (numberRepeatCount > 0)
        {
            j--;
        }
        else
        {
            numbers[i, j] = rndNumber;
        }
    }
}

Console.Write("\nОТВЕТ: ");
ArrayDisplay2D(numbers);