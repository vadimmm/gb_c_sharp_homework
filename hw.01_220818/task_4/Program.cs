string task_name = "Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.";
int separator_length = 123;
string separator = new String ('#', separator_length);
Console.Clear();
Console.WriteLine(separator);
Console.WriteLine("\n" + task_name + "\n");
Console.WriteLine(separator);
Console.WriteLine("");

Console.Write("Пожалуйста, введите первое целое число: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста, введите второе целое число: ");
int numb2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста, введите третье целое число: ");
int numb3 = Convert.ToInt32(Console.ReadLine());

int max = numb1;

if (numb2 > max) max = numb2;
if (numb3 > max) max = numb3;
Console.WriteLine("");
Console.Write("ОТВЕТ: ");
Console.WriteLine("max = " + max + ", максимальное найденное число: " + max + ".\n\n");