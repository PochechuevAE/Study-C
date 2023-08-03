//Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
Console.Write("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());
int ostatok = num % 10;
Console.WriteLine(ostatok);
//string num = Console.ReadLine(); легкое решение
//System.Console.WriteLine(num[2]);
