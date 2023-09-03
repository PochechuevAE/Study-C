// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
PrintArray(GeneraterArray(10));

int[] GeneraterArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(0, 2);
    }
    return result;
}

void PrintArray(int [] array)
{
    foreach (int i in array) //чисто для чтения 
    {
        System.Console.WriteLine($"{i}");
    }
}