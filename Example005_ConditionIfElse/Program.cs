Console.WriteLine("Введите имя пользователя.");
string UserName = Console.ReadLine();

if (UserName.ToLower() == "маша")
    {
    Console.Write("Ура! Это же Маша!!!");
    }
else
    {
    Console.Write("Привет, ");
    Console.Write(UserName);
    Console.Write("!");
    }