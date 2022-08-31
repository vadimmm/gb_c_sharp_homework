string task_name = @"Задача 3 (Дополнительная)
Назовём число «интересным», если его произведение цифр делится на их сумму. 
Напишите программу, которая заполняет массив на N «интересных» случайных целых чисел. 
(Каждый эл-т массива должен быть сгенерирован случайно)";
int separator_length = 120;
string separator = new String('#', separator_length);
Console.Clear();
Console.WriteLine(separator);
Console.WriteLine("\n" + task_name + "\n");
Console.WriteLine(separator);
Console.WriteLine("");

int intMin = -2147483648;
int intMax = 2147483647;
int countOfDigit = 0;

// int [] numbers = new int [N];
int index = 0;
int number;
for (index = 1; index > 0; index++)
{
    number = new Random().Next(intMin, intMax);
    Console.WriteLine("Случайное число: " + number);

    // посчитать длину входящего числа
    int tmp = number;
    while (tmp > 0)
    {
        tmp /= 10;
        countOfDigit++;
    }
    
    // создать массив по длине числа
    int[] digits = new int[countOfDigit];
    
    // разобрать число на цифры и записать числа в массив
    tmp = number;
    for (index = 0; index < countOfDigit; index++)
    {
        digits[index] = tmp % 10;
        tmp /= 10;
    }
    // создание суммы числа и проверка на деление
    int number_sum = 0;
    for (index = 0; index < countOfDigit; index++)
    {
        number_sum += digits[index];
    }

    int countOfGoodNumbers = 0;
    int GoodNumber = number % number_sum;
    countOfGoodNumbers++;
    Console.WriteLine($"Интересных чисел {countOfGoodNumbers}, последнее интересное число {GoodNumber}");
    

}
