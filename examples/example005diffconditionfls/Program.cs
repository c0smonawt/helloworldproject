Console.Write("Edit user name");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
   Console.WriteLine("Ура, это же маша");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}
