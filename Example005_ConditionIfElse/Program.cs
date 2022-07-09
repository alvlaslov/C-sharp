Console.Write("Insert name:");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Yeah, this is MASHA");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}