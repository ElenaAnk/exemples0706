Console.WriteLine("Введите имя пользователя:");
String username = Console.ReadLine();
if(username.ToLower() =="елена")
{
  Console.WriteLine("Ура, это же Елена!");  
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
    Console.WriteLine("!");
}