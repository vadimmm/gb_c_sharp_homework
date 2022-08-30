string task_name = @"Задача 1
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Не использовать функцию Math.Pow()";
int separator_length = 120;
string separator = new String('#', separator_length);
Console.Clear();
Console.WriteLine(separator);
Console.WriteLine("\n" + task_name + "\n");
Console.WriteLine(separator);
Console.WriteLine("");


// Получаем на ввод данные
Console.Write("Введите число 'A': ");
int number_A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 'B': ");
int number_B = Convert.ToInt32(Console.ReadLine());

int number_A_tmp = number_A;

for (int i = 1; i < number_B; i++)
{
    number_A = number_A_tmp * number_A;
    // Console.WriteLine(number_A);    
}

Console.Write($"ОТВЕТ: {number_A}");