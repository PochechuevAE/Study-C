// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).
Console.WriteLine("Введите число ");
string numStr = 12 //Console.ReadLine();
int num = int.Parse(numStr); // int.Parse преобразует строки в числа можно int.Parse(Console.ReadLine());
int result = num * num;
Console.WriteLine("Квадрат числа равняется " + result);