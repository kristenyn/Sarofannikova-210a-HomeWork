using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /// <summary>
    /// Установка
    /// </summary>
    public class Unit
    {
        public static int IdStatic = 1; // Статическая переменная для генерации уникальных идентификаторов
        public int Id { get; set; } // Идентификатор установки
        public string Name { get; set; } = ""; // Название установки
        public string Description { get; set; } = ""; // Описание установки
        public int FactoryId { get; set; } = 0; // Идентификатор завода, к которому принадлежит установка

        public Unit(string name, string desc, int factoryId) // Конструктор класса Unit
        {
            Name = name;
            Description = desc;
            FactoryId = factoryId;

            Id = Unit.IdStatic; // Присваиваем уникальный идентификатор
            Unit.IdStatic++; // Увеличиваем статический идентификатор для следующей установки
        }
    }
}
