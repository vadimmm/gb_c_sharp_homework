string task_name = "Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.";
int separator_length = 120;
string separator = new String ('#', separator_length);
Console.Clear();
Console.WriteLine(separator);
Console.WriteLine("\n" + task_name + "\n");
Console.WriteLine(separator);
Console.WriteLine("");
    
Console.Write("Пожалуйста, введите номер дня недели: ");
int day_numb = Convert.ToInt32(Console.ReadLine());

switch (day_numb)
{
    case 1:
        Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("Среда");
        break;    
    case 4:
        Console.WriteLine("Четверг");
        break; 
    case 5:
        Console.WriteLine("Пятница");
        break;
    case 6:
        Console.WriteLine("Суббота");
        break;    
    case 7:
        Console.WriteLine("Воскресенье");
        break;
}