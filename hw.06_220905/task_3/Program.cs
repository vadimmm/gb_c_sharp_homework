string task_name = @"Задача 3: * 
Найдите сумму произведений пар чисел в одномерном целочисленном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Если кол-во элементов нечетное, то элемент посередине не учитывать.
Результат сложения вывести на экран.
1, 3, 8, 3, 2 -> 11
8, 3, 4, 2 -> 28";
int separator_length = 120;
string separator = new String('#', separator_length);
Console.Clear();
Console.WriteLine(separator);
Console.WriteLine("\n" + task_name + "\n");
Console.WriteLine(separator);
Console.WriteLine("");

Console.Write("Введите количество чисел для формирования случайных чисел в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());

int numbStart = -2147483648;
int numbStop = 2147483647;
int sum = 0;

int[] numbers = new int[N];

Random rnd = new Random();

for (int i = 0; i < N; i++)
{
    numbers[i] = rnd.Next(numbStart, numbStop);
}

var str = string.Join(" ", numbers);
Console.WriteLine($"\nСгенерированные числа в массиве: {str}");

for (int i = 0; i < numbers.Length / 2; i++)
{
    int numberFirst = numbers[i];
    int numberSecond = numbers[numbers.Length - (1 + i)];
    int numberMultiply = numberFirst * numberSecond;
    sum += numberMultiply;
    // Console.WriteLine($"{numberFirst} * {numberSecond} = {numberMultiply}\n Накопленная сумма: {sum}\n ================");
}

Console.Write($"\nОТВЕТ: Сумма чисел: {sum}\n\n");