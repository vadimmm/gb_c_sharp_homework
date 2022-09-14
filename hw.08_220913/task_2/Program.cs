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

string[] paramArray = new string[2];
Console.Write("Введите, через пробел, размер двумерного массива (строки и столбцы): ");
paramArray = Console.ReadLine().Split(' ');
int row = int.Parse(paramArray[0]);
int col = int.Parse(paramArray[1]);

// int row = 8;
// int col = 2;

// заполнение массива случайными числами
Random rnd = new Random();
// int rndNumbStart = 0;
// int rndNumbStop = 9;

int[,] matrixOne = new int[row, col];
int[,] matrixTwo = new int[row, col];
int[,] matrixThree = new int[row, col];

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
    // string arrayName = Convert.ToString(array);
    Console.WriteLine($"\nСодержимое двумерного массива c данными:");
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
                arrayThree[i, j] = matrixOne[i, h] * matrixTwo[h, j];
            }
        }
    }
}

ArrayFilling2D(matrixOne, 1, 4+1);
ArrayFilling2D(matrixTwo, 5, 8+1);

ArrayDisplay2D(matrixOne);
ArrayDisplay2D(matrixTwo);

ProductOfArrayNumbers2D(matrixOne, matrixTwo, matrixThree);
ArrayDisplay2D(matrixThree);