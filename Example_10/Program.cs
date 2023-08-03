//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
Console.WriteLine("Введите номер дня недели от 1 до 7 включительно: ");
int day = int.Parse(Console.ReadLine());
if (day == 1)
{
    Console.WriteLine("Сегодня Понедельник"); //Но можно и через свич кейс
}

if (day == 2)
{
    Console.WriteLine("Сегодня Вторник");
}

if (day == 3)
{
    Console.WriteLine("Сегодня Среда");
}

if (day == 4)
{
    Console.WriteLine("Сегодня Четверг");
}

if (day == 5)
{
    Console.WriteLine("Сегодня Пятница");
}

if (day == 6)
{
    Console.WriteLine("Сегодня Суббота");
}

if (day == 7)
{
    Console.WriteLine("Сегодня Воскресенье");
}
