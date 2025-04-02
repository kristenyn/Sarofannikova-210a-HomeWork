using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Player
    {
        // Свойство для хранения имени игрока
        public string Name { get; set; } = "";

        // Список результатов игр игрока
        public List<GameResult> Results { get; set; }

        // Конструктор класса Player, принимающий имя игрока
        public Player(string name)
        {
            Name = name; // Инициализируем имя игрока
            Results = new List<GameResult>(); // Инициализируем список результатов
        }

        /// <summary>
        /// Метод для добавления результата игры в список результатов
        /// </summary>
        /// <param name="result"></param>
        
        public void AddResult(GameResult result)
        {
            Results.Add(result); 
        }

        /// <summary>
        /// Переопределение метода ToString для вывода информации о игроке и его результатах
        /// </summary>
        /// <returns></returns>
        
        public override string ToString()
        {
            string res = ""; 
            foreach (GameResult result in Results) 
                res += result.ToString() + "\n"; 
            return res;
        }
    }
}
