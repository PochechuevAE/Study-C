//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
int [] arr = GenerateArray(15);
PrintArray(arr);
int RandNum = GetNum(1);
System.Console.WriteLine(FindNum(arr, RandNum));

int GetNum(int a)
{
    a = new Random().Next(-19, 20);
    System.Console.WriteLine($"Выбрано рандомное число {a}");
    return a;
}

bool FindNum(int[] array, int RandNum)
{
   for (int i = 0; i < array.Length; i++)
   {
    if(array[i] == RandNum) 
    {
        return true;
    }
   }

   return false;
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