string task_name = @"Задача 2.
Задайте одномерный массив, заполненный случайными числами.
Найдите сумму четных элементов, стоящих на нечётных позициях (позиция - индекс элемента в массиве).
[3, 7, 23, 12] -> 12
[4, 6, 8, 1, 4] -> 6";
int separator_length = 120;
string separator = new String('#', separator_length);
Console.Clear();
Console.WriteLine(separator);
Console.WriteLine("\n" + task_name + "\n");
Console.WriteLine(separator);
Console.WriteLine("");

Console.Write("Введите количество чисел для участия в проверке: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;

int numbStart = -2147483648;
int numbStop = 2147483647;

int[] numbers = new int[N];

Random rnd = new Random();

for (int i = 0; i < N; i++)
{
    numbers[i] = rnd.Next(numbStart, numbStop);
    Console.WriteLine($"Числа сгенерированыне для масиива {numbers[i]}");
}

for (int i = 1; i < N; i += 2)
{
    if (numbers[i] % 2 == 0)
    {
        Console.WriteLine($"Числа для суммирвоания {numbers[i]}");
        sum += numbers[i];
    }
}
Console.WriteLine($"ОТВЕТ: Сумма чисел на нечётных индексах составляет {sum}.");