// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
PrintArray(GenerateArray(10));

int [] GenerateArray(int Length) 
{
    int [] result = new int[Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(0, 2);
    }

    return result;
} 

void PrintArray(int [] array)
{
    foreach (int i in array)
    {
        System.Console.WriteLine(i);
    }
}