string task_name = @"Задача 1
Программа запрашивает натуральное число M, пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3";
int separator_length = 120;
string separator = new String ('#', separator_length);
Console.Clear();
Console.WriteLine(separator);
Console.WriteLine("\n" + task_name + "\n");
Console.WriteLine(separator);
Console.WriteLine("");

int numberRndStart = 1;
int numberRndStop = 10;
int numberSum = 0;

Console.Write("Введите следующее количество целых чисел: ");
int number = new Random().Next(numberRndStart,numberRndStop);
Console.WriteLine(number);

// Получение данных от пользователя и занесение в массив
int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

for(int i = 0; i < number; i++)
{
    if(array[i] > 0)
    {
        numberSum++;
    }
}

Console.Write("\n\nОТВЕТ: ");
if (numberSum == 0)
{
    Console.WriteLine($"Введено {numberSum} положительных чисел. :(");    
}
else if (numberSum == 1)
{
    Console.WriteLine($"Введено одно положительное число: {numberSum}.");
}
else
{
    Console.WriteLine($"Количество положительных чисел составляет {numberSum}.");
}
Console.Write("\n\n");