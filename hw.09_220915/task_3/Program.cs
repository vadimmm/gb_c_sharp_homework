string task_name = @"Задача 3.
Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.";
int separator_length = 120;
string separator = new String('#', separator_length);
Console.Clear();
Console.WriteLine(separator);
Console.WriteLine("\n" + task_name + "\n");
Console.WriteLine(separator);
Console.WriteLine("");

string[] inputParamAckermann = new string[2];
Console.Write("Введите, через пробел, целые положительные числа для расчёта (m и n): ");
inputParamAckermann = Console.ReadLine().Split(' ');
int m = int.Parse(inputParamAckermann[0]);
int n = int.Parse(inputParamAckermann[1]);

int FuncAckermann(int m, int n)
{
    int result = 0;
    if (m == 0)
    {
        result = n + 1;
    }
    else if ((m != 0) && (n == 0))
    {
        result = FuncAckermann(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        result = FuncAckermann(m - 1, FuncAckermann(m, n - 1));
    }
    return result;
}

void RunTask()
{
    Console.Write($"\nОТВЕТ: ");
    Console.WriteLine(FuncAckermann(m, n));
}

RunTask();