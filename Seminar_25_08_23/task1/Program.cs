// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
int res = GetSumFrom1toN(10);
System.Console.WriteLine($"Сумма чисел от 1 до 10 равна {res}");

int GetSumFrom1toN(int a)
{
    int count = default;
    int result = default;
    
    while (count <= a)
    {
        result += count;
        count++; 
    }

    return result;
}

