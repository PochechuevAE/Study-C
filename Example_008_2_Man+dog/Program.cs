// See https://aka.ms/new-console-template for more information
int distance = 10000;
int firsfs = 1;
int secondfs = 2;
int dogs = 5;
int friend = 2;
int count = 0;
int time = 0;

while (distance > 10)
{
    if (friend == 1) 
    {
        time = distance / (firsfs + dogs);
        friend = 2;
    }
    else 
    {
        time = distance / (secondfs + dogs);
        friend = 1;
    }
    distance = distance - time * (firsfs + secondfs);
    count++;
}
Console.WriteLine("Собака пробежит " + count + " раз");