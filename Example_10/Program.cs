//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
Console.WriteLine("Введите номер дня недели от 1 до 7 включительно: ");
int day = int.Parse(Console.ReadLine());
if (day == 1)
{
    Console.WriteLine("Сегодня Понедельник"); //Но можно и через свич кейс
    return;
}

if (day == 2)
{
    Console.WriteLine("Сегодня Вторник");
    return;
}

if (day == 3)
{
    Console.WriteLine("Сегодня Среда");
    return;
}

if (day == 4)
{
    Console.WriteLine("Сегодня Четверг");
    return;
}

if (day == 5)
{
    Console.WriteLine("Сегодня Пятница");
    return;
}

if (day == 6)
{
    Console.WriteLine("Сегодня Суббота");
    return;
}

if (day == 7)
{
    Console.WriteLine("Сегодня Воскресенье");
    return;
}
