string task_name = @"Задача 2**.
Напишите программу, которая заполнит спирально двумерный массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07";
int separator_length = 120;
string separator = new String('#', separator_length);
Console.Clear();
Console.WriteLine(separator);
Console.WriteLine("\n" + task_name + "\n");
Console.WriteLine(separator);
Console.WriteLine("");


Console.Write("Введите размер стороны квадратного массива (целое положительное чило):");
int row = Convert.ToInt32(Console.ReadLine());


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

void ArrayDisplay2D_D2(int[,] array)
{
    // вывод содержимого двумерного (матричного, табличного) массива
    Console.WriteLine($"Содержимое двумерного массива c данными:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j].ToString("D2")}\t");
        }
        Console.WriteLine();
    }
}

int col = row;

int[,] numbers = new int[row, col];

void ArraySpiralFilling2D(int[,] array)
{
    int row_N = 0;
    int col_M = 0;
    int x = 1;
    int y = 0;
    int positionCount = 0;
    int temp = 0;
    int arrayValue = col;

    for (int i = 0; i < array.Length; i++)
    {
        array[row_N, col_M] = i + 1;
        if (--arrayValue == 0)
        {
            arrayValue = col * (positionCount % 2) + row * ((positionCount + 1) % 2) - (positionCount / 2 - 1) - 2;
            temp = x;
            x = -y;
            y = temp;
            positionCount++;
        }
        col_M += x;
        row_N += y;
    }
}


void ArraySpiralFilling2D_1(int[,] array)
{
    int k = 0, l = 0, x = array.GetLength(0) * array.GetLength(1) + 1;
    int number = 1;

    while (true)
    {
        for (int i = k; i < array.GetLength(1) - k; i++)
            array[l, i] = number++;
        if (number == x)
            break;
        else
            l++;
        for (int i = l; i < array.GetLength(0) - l; i++)
            array[i, array.GetLength(1) - k - 1] = number++;
        if (number == x)
            break;
        for (int i = array.GetLength(1) - k - 1; i >= k; i--)
            array[array.GetLength(0) - l, i] = number++;
        if (number == x)
            break;
        for (int i = array.GetLength(0) - l - 1; i >= l; i--)
            array[i, k] = number++;
        if (number == x)
        {
            break;
        }
        else
        {
            k++;
        }
    }
}



void RunTask(int[,] name)
{
    ArraySpiralFilling2D(name);
    ArrayDisplay2D_D2(name);
}

RunTask(numbers);