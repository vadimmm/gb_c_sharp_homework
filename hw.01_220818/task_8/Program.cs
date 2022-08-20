string task_name = "Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.";
int separator_length = 123;
string separator = new String ('#', separator_length);
Console.Clear();
Console.WriteLine(separator);
Console.WriteLine("\n" + task_name + "\n");
Console.WriteLine(separator);
Console.WriteLine("");

Console.Write("Пожалуйста, введите целое число: ");
int numb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

Console.Write("ОТВЕТ: \n");
for (int i = 2; i <= numb; i += 2)
    if (i % 2 == 0)
        Console.WriteLine(i);