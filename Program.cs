namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gebe mir deinen Namen!");
            string name = Console.ReadLine();
            
            Console.WriteLine("Hello, " + name);
        }
    }
}