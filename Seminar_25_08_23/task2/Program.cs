//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе
System.Console.WriteLine($"{GetLengthNum(48736)}");

int GetLengthNum(int num)
{
    int len = default;
    
    while (num > 0)
    {
        len++;
        num /= 10;
    }

    return len;
}