// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе

System.Console.WriteLine(GivLenghthNum(23523));

int GivLenghthNum(int num)
{
    int Lenght = default;
    
    while (num > 0) 
    {
        Lenght++;
        num /= 10;       
    }

    return Lenght;
}