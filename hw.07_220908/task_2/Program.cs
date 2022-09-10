string task_name = @"Задача 2.
Напишите программу, которая на вход принимает позиции (две) элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет";
int separator_length = 120;
string separator = new String('#', separator_length);
Console.Clear();
Console.WriteLine(separator);
Console.WriteLine("\n" + task_name + "\n");
Console.WriteLine(separator);
Console.WriteLine("");


string [] VolumeArray = new string[2];
Console.Write("Введите, через пробел, размер двумерного массива (строки и столбцы): ");
VolumeArray  = Console.ReadLine().Split(' ');
int row = int.Parse(VolumeArray[0]);
int col = int.Parse(VolumeArray[1]);

int[,] numbers = new int[row, col];

// заполнение массива случайными числами
Random rnd = new Random();
int rndNumbStart = 0;
int rndNumbStop = 10;
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[i, j] = rnd.Next(rndNumbStart, rndNumbStop);
    }
}

void printArray()
{
    // вывод содержимого массива
    Console.WriteLine("\nСодержимое массива c данными:");
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write($"{numbers[i, j]}\t");
        }
        Console.WriteLine("");
    }
}

// подсказка
printArray();

int gameStart()
{
    Console.WriteLine($"Проверим вашу удачу? Введите целое число от {rndNumbStart} и {rndNumbStop}");
    int userInput = Convert.ToInt32(Console.ReadLine());
    int userWins = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                if (numbers[i,j] == userInput)
                {
                    userWins++;
                }
            }
            // Console.WriteLine("");
        }
    // Console.WriteLine("Количество совпадений: " + userWins);
    return userWins;
}

void gameResult()
{
    int win = gameStart();
    if (win > 0)
    {
        Console.Write(@"Ваше число найдено! Поздравляем!
Вы выиграли приз, отправьте sms на номер 'abcd' и с вами обязательно свяжется наш менеджер по выигрышам!");
        // Console.Write($"Ваше число {userInput} найдено! Поздравляем! Вы выиграли приз, отправьте смс на номер 'abcd'");
        // return; 
    }
    else
    {
        Console.WriteLine(@"Такого числа нет в массиве! Нам оооочень жаль!");
        // Console.WriteLine(@"Такого числа {userInput} нет в массиве! Нам так жаль");
        printArray();
        // return;
    }
}

gameResult();