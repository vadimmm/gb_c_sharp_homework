string task_name = "Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.";
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
Console.WriteLine("");

Console.Write("ОТВЕТ: ");
if (numb1 > numb2)
{
    Console.WriteLine("Первое введённое число " + numb1 + " больше введённого второго " + numb2 + ".\n\n");
}
else if (numb1 < numb2)
{
    Console.WriteLine("Второе введённое число " + numb2 + " больше введённого первого " + numb1 + ".\n\n");
}
else if (numb1 == numb2)
{
    Console.WriteLine("Введённые числа равны.\n\n");
}
else
{
    Console.WriteLine("Какая-то ошибка, обратитесь к разработчику программы.\n\n");
}