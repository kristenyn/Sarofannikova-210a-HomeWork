using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Game
    {
        Player currentPlayer; // Текущий игрок
        int hiddenNumber = -1; // Загаданное число, по умолчанию -1

        /// <summary>
        /// Конструктор класса Game, принимает объект Player
        /// </summary>
        /// <param name="player"></param>
        public Game(Player player)
        {
            currentPlayer = player;
        }

        /// <summary>
        /// Метод для запуска игры
        /// </summary>
        public void Start()
        {
            int level = 0; // Уровень сложности
            int countAttempts = 0; // Количество попыток
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
                        hiddenNumber = NumberGenerator.GetRandomNumber(level); // Генерируем загаданное число
                        if (hiddenNumber == -1)
                            Console.WriteLine("Введите корректное значение");
                    }
                    else
                        Console.WriteLine("Введите корректное значение");
                }
                else 
                {
                    Console.Write("Введите число: ");
                    int number = 0; // Переменная для ввода числа игрока
                    
                    if (Int32.TryParse(Console.ReadLine(), out number))
                    {
                        
                        if (number < hiddenNumber)
                            Console.WriteLine("Загаданное число больше");
                        else if (number > hiddenNumber)
                            Console.WriteLine("Загаданное число меньше");
                        else 
                        {
                            currentPlayer.AddResult(new GameResult(level, countAttempts)); // Добавляем результат игры
                            Console.WriteLine("Ура. Вы победили. Загаданное число " + number);
                            Console.WriteLine("************************************************");
                            Console.WriteLine(currentPlayer.ToString()); // Выводим информацию о текущем игроке

                            // Сбрасываем значения для следующей игры
                            level = 0;
                            countAttempts = 0;
                            hiddenNumber = -1;
                        }
                        countAttempts++; // Увеличиваем количество попыток
                    }
                }
            }
        }
    }
}