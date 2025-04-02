using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    /// <summary>
    /// Класс, представляющий результат игры
    /// </summary>
    public class GameResult
    {
        // Уровень сложности игры
        public int Level { get; set; } = 0;

        // Количество попыток, потраченных на угадывание числа
        public int CountAttempts { get; set; } = 0;

        /// <summary>
        /// Конструктор класса GameResult, принимает уровень и количество попыток
        /// </summary>
        /// <param name="level"></param>
        /// <param name="countAttempts"></param>
        public GameResult(int level, int countAttempts)
        {
            Level = level; // Инициализация уровня
            CountAttempts = countAttempts; // Инициализация количества попыток
        }

        /// <summary>
        /// Переопределение метода ToString для удобного отображения результата
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Уровень: " + Level + "; Количество попыток: " + CountAttempts;
        }
    }
}
