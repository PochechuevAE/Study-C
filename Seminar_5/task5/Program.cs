// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
 
int[] arr = GenerateArray(5);
PrintArray(arr); 
int[] newArray = FindSumOfPairs(arr);
PrintArray(newArray);

int[] FindSumOfPairs(int[] array) // Находит пары элементов и умножает их]
{
    int newSize = array.Length / 2;

    if(array.Length % 2 == 1) // Проверяем длинну массива, и если она не четная, то добавляем еще элемент
    {
        newSize++;
    }

    int[] result = new int[newSize];

    for (int i = 0; i < array.Length / 2; i++) //перемножаем попарно элементы
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }

   if(array.Length % 2 == 1) // Проверяем если нечетный, то записываем средний элемент
    {
        result[newSize - 1] = array[array.Length / 2];
    }
    
    return result;
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