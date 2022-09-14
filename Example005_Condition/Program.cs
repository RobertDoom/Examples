Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "роберт")
{
    Console.WriteLine("Ура, это же Роберто!");
}
else
{
    Console.Write("Привет, ");
    Сonsole.WriteLine(username);
}