// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
int randomNumber = new Random().Next(10, 100);
int num1 = randomNumber % 10;
int num2 = randomNumber / 10;
System.Console.WriteLine($"Выбрано число: {randomNumber}"); //Строковая интерполяция удобно :)
System.Console.Write("Максимальная цифра: ");
System.Console.WriteLine(num1 > num2 ? num1 : num2);
