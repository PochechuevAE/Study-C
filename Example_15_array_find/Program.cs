// Имеется одноименный массив array из n элементов, требуется найти элемент массива, равный find
//              0  1   2   3  4   5   6   7   8   9   10 
int [] array = {1, 12, 31, 4, 15, 16, 17, 18, 18, 91, 105};
System.Console.WriteLine("1, 12, 31, 4, 15, 16, 17, 18, 18, 91, 105");
int n = array.Length;
int index = 0;
System.Console.WriteLine("Введите элемент, который требуется");
int find = int.Parse(Console.ReadLine());
{
    while (index < n)
    {
        if (array[index] == find)
        {
            Console.WriteLine(index);
            break;
        }
        index++;
    }   
}