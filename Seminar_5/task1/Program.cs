//Задайте массив из 12 элементов, заполненный
//случайными числами из промежутка [-9, 9]. Найдите сумму
//отрицательных и положительных элементов массива
int [] arr = GenerateArray(12);
PrintArray(arr);
System.Console.WriteLine($"Сумма положительных элементов массива равна {GetSumMoreZero(arr)}");
System.Console.WriteLine($"Сумма положительных элементов массива равна {GetSumLessZero(arr)}");

int [] GenerateArray(int Length) // генерируем рандомный массив
{
    int [] result = new int[Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(-9, 9);
    }

    return result;
} 

void PrintArray(int [] array) // Печатаем этот массив
{
    foreach (int i in array)
    {
        System.Console.Write($"{i} ");
    }
    System.Console.WriteLine();
}

int GetSumMoreZero(int [] array) // Сумма положительных элементов массива
{
    int result = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0)
        {
            result += array[i];
        }
    } 

    return result;
}

int GetSumLessZero(int [] array) // Сумма отрицательных элементов массива
{
    int result = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            result += array[i];
        }
    } 

    return result;
}
