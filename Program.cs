namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gebe mir deinen Namen!");
            string name = Console.ReadLine();

            Console.WriteLine("Sage mir wie alt du bist");
            
            int age = Convert.ToInt16(Console.ReadLine());

            int alterInZehn = age + 10;
            
            Console.WriteLine("Hello, " + name + " Dein Alter ist " + age + " In Zehn jahren bist du" + alterInZehn );
        }
    }
}