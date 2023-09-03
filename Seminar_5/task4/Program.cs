// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
int [] arr = GenerateArray(123);
PrintArray(arr); 
System.Console.WriteLine($"Кол-во элементов массива в данном диапазоне = {FindNumInInterval(arr)}");

int FindNumInInterval(int[] array) // Находит кол-во элементов в заданом интервале [10; 99]
{
    int count = default;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 10 && array[i] <= 99)
        count++;

    }
    return count;
}

int [] GenerateArray(int Length) 
{
    int [] result = new int[Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(1, 1000);
    }

    return result;
} 

void PrintArray(int [] array)
{
    foreach (int i in array)
    {
        System.Console.Write($"{i} ");
    }
    System.Console.WriteLine();
}