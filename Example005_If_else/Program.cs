Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "Маша")
{
    Console.WriteLine("Ура, Это же МАША!");
}
else
{
    Console.WriteLine("Привет,");
    Console.WriteLine(username);
}
