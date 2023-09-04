// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.


int x = new Random().Next(1, 10);
int y = new Random().Next(1, 10);
int z = new Random().Next(1, 10);
System.Console.WriteLine($"Выбраны числа {x}  {y}  {z} может ли существовать треугольник?");
System.Console.WriteLine(IsTriangle( x, y, z));

bool IsTriangle(int x, int y, int z) 
{
    return ((x + y) > z) && ((x + z) > y) && ((y + z) > z);
}
    
// var istriangle = (int x, int y, int z) =>
//     ((x + y) > z) && ((x + z) > y) && ((y + z) > z)
// System.Console.WriteLine($"{x}  {y}  {z}");
// System.Console.WriteLine(IsTriangle( x, y, z));
