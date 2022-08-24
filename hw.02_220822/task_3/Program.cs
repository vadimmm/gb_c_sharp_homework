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

void dayWork()
{
    Console.ForegroundColor = ConsoleColor.Blue;
}

void dayOff()
{
    Console.ForegroundColor = ConsoleColor.Red;
}

switch (day_numb)
{
    case 1:
        dayWork();
        Console.WriteLine("Понедельник");
        Console.WriteLine("РАБОЧИЙ ДЕНЬ");
        Console.WriteLine("");
        Console.WriteLine("Слово «понедельник» образовано от «после недели». Понедельник был первым днем после воскресенья, которое в древности называлось «неделей». Корень слова — понедель.");
        Console.ResetColor();
        break;
    case 2:
        dayWork();
        Console.WriteLine("Вторник");
        Console.WriteLine("РАБОЧИЙ ДЕНЬ");
        Console.WriteLine("");
        Console.WriteLine("Вторник — от слова «второй». Второй день после «недели» (нынешнего воскресенья). Заметьте — не второй день недели, а второй после недели.");
        Console.ResetColor();
        break;
    case 3:
        dayWork();
        Console.WriteLine("Среда");
        Console.WriteLine("РАБОЧИЙ ДЕНЬ");
        Console.WriteLine("");
        Console.WriteLine("Это слово тоже пришло из старославянского (как и «неделя», «понедельник», «вторник»). Имеет общий корень со словами «сердце», «середина». Обратите внимание: среда является серединой недели лишь в том случае, если неделя начинается с воскресенья.");
        Console.ResetColor();
        break;
    case 4:
        dayWork();
        Console.WriteLine("Четверг");
        Console.WriteLine("РАБОЧИЙ ДЕНЬ");
        Console.WriteLine("");
        Console.WriteLine("Как и «вторник», слово «четверг» образовано в соответствии с порядковым номером дня недели после воскресенья. «Четверг» образовано от общеславянского слова «четвьртъкъ», которое, в свою очередь, суффиксальным способом образовалось от слова «четвертый». Скорее всего, со временем выпал звук «т» — остался «четверк», а постепенно звук «к» «озвончился», так как он следует за сонорным (всегда звонким) звуком «р».");
        Console.ResetColor();
        break;
    case 5:
        dayWork();
        Console.WriteLine("Пятница");
        Console.WriteLine("РАБОЧИЙ ДЕНЬ");
        Console.WriteLine("");
        Console.WriteLine("С пятницей все немного сложнее. Конечно, слово образовано от цифры «пять» (пятый день после начала недели). Но почему не «пятник» или «пятак»? Дело в том, что еще до принятия христианства почиталась славянская богиня Пятница (имеющая отношение к пятому дню). Поэтому пятый день назвали в честь богини именно Пятницей, а не Пятником.");
        Console.ResetColor();
        break;
    case 6:
        dayOff();
        Console.WriteLine("Суббота");
        Console.WriteLine("ВЫХОДНОЙ ДЕНЬ");
        Console.WriteLine("");
        Console.WriteLine("Слово пришло из старославянского языка. Когда-то оно было заимствовано из греческого языка (от греч. Sabbaton). А в греческий язык оно попало из древнееврейского языка (от sabbath — «седьмой день, когда нужно воздерживаться от работы»). Шаббат — так произносится это еврейское слово, означающее буквально «покой», «отдых».");
        Console.ResetColor();
        break;
    case 7:
        dayOff();
        Console.WriteLine("Воскресенье");
        Console.WriteLine("ВЫХОДНОЙ ДЕНЬ");
        Console.WriteLine("");
        Console.WriteLine("Воскресенье — это слово, как уже было сказано, пришло на смену слову «неделя». Возникло оно, конечно же, после принятия на Руси христианства. Слово является производным от «въскресити». Образовано суффиксальным способом (суффикс -ениj-). Это день, когда, согласно писаниям, воскрес Иисус.");
        Console.ResetColor();
        break;
}