//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N
Console.Write("Введите число: ");
int Num = int.Parse(Console.ReadLine());
int otrNum = - Num;
while (otrNum <= Num)
{
    System.Console.WriteLine(otrNum);
    otrNum++;
}
