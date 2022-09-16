string task_name = @"Задача 2: 
Задайте две квадратные матрицы одного размера.
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18";
int separator_length = 120;
string separator = new String('#', separator_length);
Console.Clear();
Console.WriteLine(separator);
Console.WriteLine("\n" + task_name + "\n");
Console.WriteLine(separator);
Console.WriteLine("");

// Якорь
startProgram:

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

string[] arrayParam = new string[2];

Console.Write("Введите, через пробел, размер используемых двумерных массивов (строки и столбцы): ");
arrayParam = Console.ReadLine().Split(' ');
int row = int.Parse(arrayParam[0]);
int col = int.Parse(arrayParam[1]);
Console.Write("Вы ввели следующие координаты: ");
WriteColorMessage(2, $"[{row},{col}]");
Console.WriteLine("");

// int row = 8;
// int col = 2;

// заполнение массива случайными числами
Random rnd = new Random();

int[,] matrixOne = new int[row, col];
int[,] matrixTwo = new int[row, col];
int[,] matrixResult = new int[row, col];

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

void ProductOfArrayNumbers2D(int[,] arrayOne, int[,] arrayTwo, int[,] arrayThree)
// Расчёт произведения матриц из двух матричных массивов
{
    for (int i = 0; i < arrayOne.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTwo.GetLength(1); j++)
        {
            arrayThree[i, j] = 0;
            for (int h = 0; h < arrayThree.GetLength(1); h++)
            {
                arrayThree[i, j] += matrixOne[i, h] * matrixTwo[h, j];
            }
        }
    }
}

if (row < col)
{
    WriteColorMessage(3, $"[i] Массив не правильной размерности [{row},{col}].\n" + 
                          "Операция умножения двух матриц выполнима только в том случае, если число столбцов в первом " +
                          "сомножителе равно числу строк во втором; в этом случае говорят, что матрицы согласованы. " + 
                          "В частности, умножение всегда выполнимо, если оба сомножителя — квадратные матрицы одного и того же порядка.\n\n" +
                          "[www] https://ru.wikipedia.org/wiki/Умножение_матриц");
    WriteColorMessage(0, $"Попробуйте ещё раз...");
    Console.WriteLine("");
    goto startProgram;
}
else
{
    // Задаём случайные интервалы для каждого массива
    ArrayFilling2D(matrixOne, 1, 5);
    ArrayFilling2D(matrixTwo, 5, 10);

    // Console.BackgroundColor = ConsoleColor.Yellow;
    // Console.ForegroundColor = ConsoleColor.Black;
    ArrayDisplay2D(matrixOne);
    // Console.ResetColor();
    Console.WriteLine("");
    // Console.BackgroundColor = ConsoleColor.Blue;
    // Console.ForegroundColor = ConsoleColor.Black;
    ArrayDisplay2D(matrixTwo);
    // Console.ResetColor();
    Console.WriteLine("");

    ProductOfArrayNumbers2D(matrixOne, matrixTwo, matrixResult);
    
    Console.BackgroundColor = ConsoleColor.DarkGreen;
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("\nОТВЕТ: ");
    ArrayDisplay2D(matrixResult);
    Console.ResetColor();
}