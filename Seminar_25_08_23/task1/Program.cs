//Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
int res = GetSumFrom1ToN(10);
System.Console.WriteLine($"Сумма чисел от 1 до 10 равна {res}");

int GetSumFrom1ToN(int a)
{
    int result = default;
    int count = default;

    while (count <= a)
    {
        result += count;
        count++;
    }

    return result;
}