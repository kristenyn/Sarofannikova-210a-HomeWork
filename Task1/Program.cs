using System.Linq;
using System;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tanks = GetTanks(); // Получаем массив резервуаров
            var units = GetUnits(); // Получаем массив установок
            var factories = GetFactories(); // Получаем массив заводов
            Console.WriteLine($"Количество резервуаров: {tanks.Length}, установок: {units.Length}"); // Выводим количество резервуаров и установок

            // Вывод всех резервуаров с информацией о цехе и фабрике
            Console.WriteLine("\nСписок всех резервуаров:");
            foreach (var tank in tanks)
            {
                var unit = FindUnit(units, tank.UnitId);
                var factory = FindFactory(factories, unit.FactoryId);
                Console.WriteLine($"Резервуар: {tank.Name}, Цех: {unit.Name}, Фабрика: {factory.Name}, Объем: {tank.Volume}");
            }

            // Вывод общей суммы загрузки всех резервуаров
            var totalVolume = GetTotalVolume(tanks); // Получаем общий объем резервуаров
            Console.WriteLine($"\nОбщий объем резервуаров: {totalVolume}"); // Выводим общий объем

            // Поиск резервуара по имени
            Console.WriteLine("\nВведите название резервуара для поиска:");
            string searchName = Console.ReadLine();
            var foundTank = SearchTankByName(tanks, searchName);
            if (foundTank != null)
            {
                var unit = FindUnit(units, foundTank.UnitId);
                var factory = FindFactory(factories, unit.FactoryId);
                Console.WriteLine($"Найден резервуар: {foundTank.Name}, Цех: {unit.Name}, Фабрика: {factory.Name}, Объем: {foundTank.Volume}");
            }
            else
            {
                Console.WriteLine("Резервуар не найден.");
            }
        }

        // Метод для получения массива резервуаров
        public static Tank[] GetTanks()
        {
            Tank[] array = new Tank[6]; // Создаем массив резервуаров

            array[0] = new Tank("Резервуар 1", "Надземный - вертикальный", 1500, 2000, 1); // Инициализируем резервуары
            array[1] = new Tank("Резервуар 2", "Надземный - горизонтальный", 2500, 3000, 1);
            array[2] = new Tank("Дополнительный Резервуар 24", "Надземный - горизонтальный", 3000, 3000, 2);
            array[3] = new Tank("Резервуар 35", "Надземный - вертикальный", 3000, 3000, 2);
            array[4] = new Tank("Резервуар 47", "Надземный - двустенный", 4000, 5000, 2);
            array[5] = new Tank("Резервуар 256", "Подводный", 500, 500, 3);

            return array; 
        }

        // Метод для получения массива установок
        public static Unit[] GetUnits()
        {
            Unit[] array = new Unit[3]; // Создаем массив установок

            array[0] = new Unit("ГФУ-2", "Газофракционирующая установка", 1); // Инициализируем установки
            array[1] = new Unit("АВТ-6", "Атмосферно-вакуумная трубчатка", 1);
            array[2] = new Unit("АВТ-10", "Атмосферно-вакуумная трубчатка", 2);

            return array; 
        }

        // Метод для получения массива заводов
        public static Factory[] GetFactories()
        {
            Factory[] array = new Factory[2]; // Создаем массив заводов

            array[0] = new Factory("НПЗ№1", "Первый нефтепереробатывающий завод"); // Инициализируем заводы
            array[1] = new Factory("НПЗ№2", "Второй нефтепереробатывающий завод");

            return array; 
        }

        // Метод для поиска установки по идентификатору
        public static Unit FindUnit(Unit[] units, int unitId)
        {
            return units.FirstOrDefault(u => u.Id == unitId); // Находим установку по идентификатору
        }

        // Метод для поиска завода по идентификатору
        public static Factory FindFactory(Factory[] factories, int factoryId)
        {
            return factories.FirstOrDefault(f => f.Id == factoryId); // Находим завод по идентификатору
        }

        // Метод для получения суммарного объема резервуаров
        public static int GetTotalVolume(Tank[] tanks)
        {
            int summ = 0; // Переменная для хранения суммы объемов
            for (int i = 0; i < tanks.Length; i++) // Проходим по массиву резервуаров
            {
                summ += tanks[i].Volume; // Суммируем объемы резервуаров
            }
            return summ; 
        }

        // Метод для поиска резервуара по имени
        public static Tank SearchTankByName(Tank[] tanks, string name)
        {
            return tanks.FirstOrDefault(t => t.Name.Equals(name, StringComparison.OrdinalIgnoreCase)); // Находим резервуар по имени
        }
    }
}
