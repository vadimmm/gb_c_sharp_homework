string task_name = @"Задача 3.
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.";
int separator_length = 120;
string separator = new String('#', separator_length);
Console.Clear();
Console.WriteLine(separator);
Console.WriteLine("\n" + task_name + "\n");
Console.WriteLine(separator);
Console.WriteLine("");

// string [] VolumeArray = new string[2];
// Console.Write("Введите, через пробел, размер двумерного массива (строки и столбцы): ");
// VolumeArray  = Console.ReadLine().Split(' ');
// int row = int.Parse(VolumeArray[0]);
// int col = int.Parse(VolumeArray[1]);

int row = 2;
int col = 5;

int[,] numbers = new int[row, col];

// заполнение массива случайными числами
Random rnd = new Random();
int rndNumbStart = 1;
int rndNumbStop = 10;
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[i, j] = rnd.Next(rndNumbStart, rndNumbStop);
    }
}

void printArray()
{
    // вывод содержимого массива
    Console.WriteLine("\nСодержимое массива c данными:");
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write($"{numbers[i, j]}\t");
        }
        Console.WriteLine();
    }
}

printArray();


// 
double average = 0;
int sum = 0;

for (int i = 0; i < numbers.GetLength(0); i++)
{
    int numb = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        Console.Write($"{i}:{j}\t");
        sum += numbers[i, j];
        numb++;
    }
    average = (double)sum / numb;
    Console.WriteLine($"\nNUMB = {numb}; SUM = {sum}; AVERAGE = {Math.Round(average, 1)}\n");
    sum = numb = 0;
}