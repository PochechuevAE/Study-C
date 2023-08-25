// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
int res = GetSumFrom1ToN(10);
System.Console.WriteLine(res);
int GetSumFrom1ToN(int a)
{
  int result = 0;
  int count = 0;
  while (count <= a)
  {
    result += count;
    count++;
  }

  return result;
}

