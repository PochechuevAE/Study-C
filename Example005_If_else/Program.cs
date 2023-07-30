// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "masha")
{
    Console.WriteLine("Ура, Это же МАША!");
}
else 
{
    Console.WriteLine("Привет,");
    Console.WriteLine(username);
}