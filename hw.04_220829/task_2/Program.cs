string task_name = @"Задача 2
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе, 
которые являются делителями этого числа.
(для получения цифр числа операцию приведения числа к строке не использовать)";
int separator_length = 120;
string separator = new String('#', separator_length);
Console.Clear();
Console.WriteLine(separator);
Console.WriteLine("\n" + task_name + "\n");
Console.WriteLine(separator);
Console.WriteLine("");

// принять входящее число
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// поситать длину входящего числа
int countOfDigit = 0;
int count_tmp = number;
while (count_tmp > 0)
{
    count_tmp /= 10;
    countOfDigit++;
}
Console.WriteLine("Длина числа: " + countOfDigit + " в числе " + number);

// создать массив по длине числа
int[] digits = new int[countOfDigit];

// разобрать число на цифры и записать числа в массив
int tmp = number;
for (int index = 0; index < countOfDigit; index++)
{
    digits[index] = tmp % 10;
    Console.WriteLine($"Для индекса {index} записано число {digits[index]}");
    tmp /= 10;
}

// печать полученного массива
var str = string.Join(" ", digits);
Console.WriteLine("Данные в массиве: " + str);

// проверка условия делителей
int sum = 0;
for (int index = 0; index < countOfDigit - 1; index++)
{
    if (digits[index] == 0)
    {
        Console.WriteLine($"Найдена цифра {digits[index]}, на неё делить нельзя.");
    }
    else if (number % digits[index] == 0)
    {
        Console.WriteLine($"Найдена подходящяя под условие цифра: {digits[index]}");
        sum += digits[index];
    }

}
Console.WriteLine($"Для числа {number}, сумма делителей составляет {sum}");