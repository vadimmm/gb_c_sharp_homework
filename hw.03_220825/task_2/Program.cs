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

Console.Write("Пожалуйста, введите координаты 'X' точки A: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Пожалуйста, введите координаты 'Y' точки A: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Пожалуйста, введите координаты 'Z' точки A: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Координаты точки A: X;Y;Z = {xA};{yA};{zA}");
// 🅰

Console.Write("Пожалуйста, введите координаты 'X' точки B: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Пожалуйста, введите координаты 'Y' точки B: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Пожалуйста, введите координаты 'Z' точки B: ");
double zB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Координаты точки B: X;Y;Z = {xB};{yB};{zB}");
// 🅱

double result = Math.Cbrt(Math.Exp(xB-xA) + Math.Exp(yB - yA) + Math.Exp(zB - zA));
Console.WriteLine($"ОТВЕТ: Расстояние между точками: {result}");
// 🆎