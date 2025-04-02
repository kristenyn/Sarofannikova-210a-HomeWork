namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите ваше имя:");
            string name = Console.ReadLine();
            Player player = new Player(name);
            Game game = new Game(player);
            game.Start();



            Console.ReadLine();
        }   
    }
}
