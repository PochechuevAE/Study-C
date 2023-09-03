//: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
int [] arr = GenerateArray(5);
PrintArray(arr);
PrintArray(ReplaseNum(arr));

int [] ReplaseNum(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] *= -1;
    return array;
} 

int [] GenerateArray(int Length) 
{
    int [] result = new int[Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(-19, 20);
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