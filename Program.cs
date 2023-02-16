internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Hello, World!");
        Console.WriteLine("This is a new sentence");

       /* string userName;

        Console.WriteLine("Enter username: ");
        userName = Console.ReadLine();
        Console.WriteLine("Username is " + userName);*/

        Console.WriteLine("Enter username: ");
        string userName = Console.ReadLine();
        object value = Console.WriteLine("Username is " + userName);

        
    }
}