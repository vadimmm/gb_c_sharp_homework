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

string [] VolumeArray = new string[2];
Console.Write("Введите, через пробел, размер двумерного массива (строки и столбцы): ");
VolumeArray  = Console.ReadLine().Split(' ');
int row = int.Parse(VolumeArray[0]);
int col = int.Parse(VolumeArray[1]);

// int row = 3;
// int col = 5;

int[,] numbers = new int[row, col];
int[,] numbersTMP = new int[col, row];
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

// B - [,]
void printArrayB(int[,] array)
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

printArrayB(numbers);

// Поворот масcива на 90 градусов вправо
for (int i = 0; i < numbers.GetLength(0); i++)
{
    int numb = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        numbersTMP[j,i] = numbers[i, j];
    }
}
// вывод массива повернутого на 90 градусов вправо 
// printArrayB(numbersTMP);

int sum = 0;
double average = 0;
string result = "";
for (int i = 0; i < numbersTMP.GetLength(0); i++)
{
    int numb = 0;
    for (int j = 0; j < numbersTMP.GetLength(1); j++)
    {
        sum += numbersTMP[i, j];
        numb++;
    }
    average = Math.Round((double) sum / numb, 1);
    result =  average.ToString() + "; " + result;
    sum = numb = 0;
} 

Console.WriteLine($"\nОТВЕТ: Среднее арифметическое каждого столбца: {result}\n\n");