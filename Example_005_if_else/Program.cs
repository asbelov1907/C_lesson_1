Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "антон")
{
    Console.WriteLine("Ура, это же Антон!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}