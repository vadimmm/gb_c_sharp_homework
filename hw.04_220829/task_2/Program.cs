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

// посчитать длину входящего числа
int countOfDigit = 0;
int count_tmp = number;
while (count_tmp > 0)
{
    count_tmp /= 10;
    countOfDigit++;
}

// создать массив по длине числа
int[] digits = new int[countOfDigit];

// разобрать число на цифры и записать числа в массив
int tmp = number;
for (int index = 0; index < countOfDigit; index++)
{
    digits[index] = tmp % 10;
    tmp /= 10;
}

// проверка условия делителей
int dividerSum = 0;
int countDivider = 0;
for (int index = 0; index < countOfDigit; index++)
{
    if (digits[index] == 0)
    {
        Console.WriteLine($"Найдена цифра {digits[index]}, на неё делить нельзя. Проверяем следующее число из массива.");
    }
    else if (number % digits[index] == 0)
    {
        dividerSum += digits[index];
        countDivider++;
    }
}

// вывод описания результата
Console.Write($"\n\nОТВЕТ: ");

if (countDivider == 0)
{
    Console.WriteLine($"Для числа {number} не найден делитель.\n\n");    
}
else if (countDivider == 1)
{
    Console.WriteLine($"Для числа {number}, найден один делитель, число {dividerSum}.\n\n");
}
else if ((2 <= countDivider) && (countDivider <= 4))
{
    Console.WriteLine($"Для числа {number}, найдено {countDivider} делителя, сумма делителей составляет {dividerSum}.\n\n");
}
else if ((5 <= countDivider) && (countDivider <= 20))
{
    Console.WriteLine($"Для числа {number}, найдено {countDivider} делителей, сумма делителей составляет {dividerSum}.\n\n");
}