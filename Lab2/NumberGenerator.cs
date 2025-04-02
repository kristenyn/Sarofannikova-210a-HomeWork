using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    static class NumberGenerator
    {
        /// <summary>
        /// Метод для генерации случайного числа в зависимости от уровня сложности
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        
        public static int GetRandomNumber(int level)
        {
            Random rand = new Random(); // Создаем экземпляр генератора случайных чисел
            switch (level)
            {
                case 1: // Легкий уровень
                    return rand.Next(1, 10); // Генерируем число от 1 до 9
                case 2: // Средний уровень
                    return rand.Next(1, 50); // Генерируем число от 1 до 49
                case 3: // Сложный уровень
                    return rand.Next(1, 100); // Генерируем число от 1 до 99
                default: 
                    return -1; // Возвращаем -1 для обозначения ошибки
                    break; 
            }
        }
    }
}
