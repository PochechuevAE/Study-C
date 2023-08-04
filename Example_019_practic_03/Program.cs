// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
int num1 = 4;
int num2 = 16;

if (Math.Pow(num1, 2) == num2) // Возводит число в степень Math.Pow(число, степень)
{
    System.Console.WriteLine("Число является квадратом другого числа");
    return;
}

if (Math.Pow(num2, 2) == num1) 
{
    System.Console.WriteLine("Число является квадратом другого числа");
    return;
}

else 
{
    System.Console.WriteLine("Число не является квадратом другого числа");
}