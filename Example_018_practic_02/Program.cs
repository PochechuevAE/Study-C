// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int newNumber = new Random().Next(100, 1000);
System.Console.WriteLine(newNumber);
System.Console.WriteLine((newNumber / 100) * 10 + (newNumber % 10)); 
