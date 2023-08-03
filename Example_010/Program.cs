// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
Console.WriteLine("Введите первое число: ");
int num_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num_2 = int.Parse(Console.ReadLine());

if (num_1 * num_1 == num_2)                                      
{
    Console.WriteLine("Число 2 является квадратом числа 1");
}
else
{
    Console.WriteLine("Число 2 не является квадратом числа 1");
}
//Console.WriteLine(num1 * num_1 == num2 ? "Число 2 является квадратом числа 1" : "Число 2 не является квадратом числа 1"); // второе решение