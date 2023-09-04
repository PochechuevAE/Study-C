// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

var arr = GenerateArray(5);
System.Console.WriteLine("Задан массив: ");
PrintArray(arr); 
ReverseArray(arr);
System.Console.WriteLine("Перевернутый массив выглядит так: ");
PrintArray(arr);

void ReverseArray(int[] array)
{
    for(int i = 0; i < array.Length / 2; i++)
    {
        int tmp = array[i];
        array[i] = array[array.Length - 1 - i]; 
        array[array.Length - 1 - i] = tmp;
    }
}

int [] GenerateArray(int Length) 
{
    int [] result = new int[Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(1, 11);
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