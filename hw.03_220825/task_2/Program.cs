string task_name = @"Задача 2
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.";
int separator_length = 120;
string separator = new String('#', separator_length);
Console.Clear();
Console.WriteLine(separator);
Console.WriteLine("\n" + task_name + "\n");
Console.WriteLine(separator);
Console.WriteLine("");

void setDotName(string name)
{
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.Write(" " + name + " ");
    Console.ResetColor();
}


// 🅰
Console.Write("Пожалуйста, введите координаты точки ");
setDotName("A");
Console.Write("\n- координаты 'X': ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("- координаты 'Y': ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("- координаты 'Z': ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write($"Вы ввели слудеющие координаты точки ");
setDotName("A");
Console.Write($": X;Y;Z = {xA};{yA};{zA}\n\n");

// 🅱
Console.Write("Теперь, введите координаты точки ");
setDotName("B");
Console.Write("\n- координаты 'X': ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("- координаты 'Y': ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("- координаты 'Z': ");
double zB = Convert.ToDouble(Console.ReadLine());
Console.Write($"Вы ввели слудеющие координаты точки ");
setDotName("B");
Console.Write($": X;Y;Z = {xB};{yB};{zB}\n\n");

// 🆎
double result = Math.Cbrt(Math.Exp(xB-xA) + Math.Exp(yB - yA) + Math.Exp(zB - zA));

Console.Write("ОТВЕТ: Расстояние между точками ");
setDotName("AB");
Console.Write($" составляет {result} единиц измерения.\n\n");