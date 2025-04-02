using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Game
    {
        Player currentPlayer;
        int hiddenNumber = -1;

        public Game(Player player)
        {
            currentPlayer = player;
        }

        public void Start()
        {
            int level = 0;
            int countAttempts = 0;
            while (true)
            {
                if (hiddenNumber == -1)
                {
                    Console.WriteLine("************************************************");
                    Console.WriteLine("Укажите сложность игры:");
                    Console.WriteLine("1. Легкий: от 1 до 10\r\n" +
                        "2. Средний: от 1 до 50\r\n" +
                        "3. Сложный: от 1 до 100");
                    
                    if (Int32.TryParse(Console.ReadLine(), out level))
                    {
                        hiddenNumber = NumberGenerator.GetRandomNumber(level);
                        if (hiddenNumber == -1)
                            Console.WriteLine("Введите корректное значение");
                    }
                    else
                        Console.WriteLine("Введите корректное значение");
                }
                else
                {
                    Console.Write("Введите число: ");
                    int number = 0;
                    if (Int32.TryParse(Console.ReadLine(), out number))
                    {
                        if (number < hiddenNumber)
                            Console.WriteLine("Загаданное число больше");
                        else if (number > hiddenNumber)
                            Console.WriteLine("Загаданное число меньше");
                        else
                        {
                            currentPlayer.AddResult(new GameResult(level, countAttempts));
                            Console.WriteLine("Ура. Вы победили. Загаданное число " + number);
                            Console.WriteLine("************************************************");
                            Console.WriteLine(currentPlayer.ToString());

                            level = 0;
                            countAttempts = 0;
                            hiddenNumber = -1;
                        }
                        countAttempts++;
                    }
                }

            }
        }
    }
}
