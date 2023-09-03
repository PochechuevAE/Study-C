System.Console.WriteLine($"{GetLengthNum(48736)}");

int GetLengthNum(int num)
{
    int len = default;
    
    while (num > 0)
    {
        len++;
        num /= 10;
    }

    return len;
}