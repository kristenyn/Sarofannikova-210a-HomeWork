using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /// <summary>
    /// Завод
    /// </summary>
    public class Factory
    {
        public static int IdStatic = 1; // Статическая переменная для генерации уникальных идентификаторов
        public int Id { get; set; } // Идентификатор завода
        public string Name { get; set; } = ""; // Название завода
        public string Description { get; set; } = ""; // Описание завода

        public Factory(string name, string desc) // Конструктор класса Factory
        {
            Name = name;
            Description = desc;
            Id = Factory.IdStatic; // Присваиваем уникальный идентификатор
            Factory.IdStatic++; // Увеличиваем статический идентификатор для следующего завода
        }
    }
}
