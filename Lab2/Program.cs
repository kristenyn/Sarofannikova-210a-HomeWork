namespace Lab2
{
    internal class Program
    {
        /// <summary>
        /// Главный метод программы, точка входа
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Запрашиваем у пользователя его имя
            Console.WriteLine("Укажите Ваше имя:");
            string name = Console.ReadLine(); // Считываем имя с консоли

            // Создаем объект игрока с введенным именем
            Player player = new Player(name);

            // Создаем объект игры, передавая игрока
            Game game = new Game(player);

            // Запускаем игру
            game.Start();

            // Ожидаем нажатия клавиши перед завершением программы
            Console.ReadLine();
        }
    }
}
