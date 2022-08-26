string task_name = @"Задача 3:
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.";
int separator_length = 120;
string separator = new String('#', separator_length);
Console.Clear();
Console.WriteLine(separator);
Console.WriteLine("\n" + task_name + "\n");
Console.WriteLine(separator);
Console.WriteLine("");

Console.Write("Пожалуйста, введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
// int N = 3;
// Console.Write("ОТВЕТ: ");

int[] array = new int[N];

int index = 0;
int num = 1;

for (Console.Write("ОТВЕТ: "); index < N; Console.Write(array[index] + " "), index++, num++)
    array[index] = (int)Math.Pow(num, 3);
// Console.Write(array[index] + " ");
// num++;