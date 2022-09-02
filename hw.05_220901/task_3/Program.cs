string task_name = @"Задача 3 (Дополнительная).
Задайте массив натуральных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76";
int separator_length = 120;
string separator = new String('#', separator_length);
Console.Clear();
Console.WriteLine(separator);
Console.WriteLine("\n" + task_name + "\n");
Console.WriteLine(separator);
Console.WriteLine("");

Console.Write("Введите количество чисел для участия в проверке: ");
int N = Convert.ToInt32(Console.ReadLine());

int numbStart = -2147483648;
int numbStop = 2147483647;

int numbMin = 0;
int numbMax = 0;

int[] numbers = new int[N];

Random rnd = new Random();

for (int i = 0; i < N; i++)
{
    numbers[i] = rnd.Next(numbStart, numbStop);
}

int MinMaxArrayNumbers(string value)
{
    int numb = numbers[0];
    if (value == "min")
    {
        for (int i = 0; i < N; i++)
        {
            if (numb < numbers[i])
            {
                numb = numbers[i];
            }
        }
    }
    else if (value == "max")
    {
        for (int i = 0; i < N; i++)
        {
            if (numb > numbers[i])
            {
                numb = numbers[i];
            }
        }
    }
    else
    {
        Console.Write("Не верные входные данные...");
    }
    return numb;
}

numbMin = MinMaxArrayNumbers("min");
numbMax = MinMaxArrayNumbers("max");

int result = numbMax - numbMin;
Console.WriteLine($"ОТВЕТ: Разница между максимальным {numbMax} и минимальным {numbMin} элементом массива сосставляет {result}.");