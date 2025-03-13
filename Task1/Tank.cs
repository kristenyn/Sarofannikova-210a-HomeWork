using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /// <summary>
    /// Резервуар
    /// </summary>
    public class Tank
    {
        public static int IdStatic = 1; // Статическая переменная для генерации уникальных идентификаторов
        public int Id { get; set; } // Идентификатор резервуара
        public string Name { get; set; } = ""; // Название резервуара
        public string Description { get; set; } = ""; // Описание резервуара
        public int Volume { get; set; } = 0; // Текущий объем резервуара
        public int MaxVolume { get; set; } = 0; // Максимальный объем резервуара
        public int UnitId { get; set; } = 0; // Идентификатор установки, к которой принадлежит резервуар

        public Tank(string name, string desc, int volume, int maxVolume, int unitId) // Конструктор класса Tank
        {
            Name = name;
            Description = desc;
            Volume = volume;
            MaxVolume = maxVolume;
            UnitId = unitId;

            Id = Tank.IdStatic; // Присваиваем уникальный идентификатор
            Tank.IdStatic++; // Увеличиваем статический идентификатор для следующего резервуара
        }
    }
}
