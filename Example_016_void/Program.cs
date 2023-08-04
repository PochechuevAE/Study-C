// Имеется одноименный массив array из n элементов, требуется найти элемент массива, равный find

void FillArray(int[] collection) // вводим метод в котором элементы массива заполняются рандомными числами от 1 до 10
{
    int lengh = collection.Length;
    int index = 0;
    while (index < lengh)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) // вводим метод который будет печатать массив
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

int indexOff(int[] collection, int find) // вводим метод который будет возвращать индекс элемента ммассива
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // если такого элемента не найдено, то индекс будет равен -1
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int[10]; // массив из 10 элементов

FillArray(array);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine("Введите элемент для поиска его позиции: ");
int find = int.Parse(Console.ReadLine());
int pos = indexOff(array, find);
System.Console.WriteLine(pos);