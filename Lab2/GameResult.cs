using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class GameResult
    {
        public int Level { get; set; } = 0;
        public int CountAttempts { get; set; } = 0;

        public GameResult(int level, int countAttempts)
        {
            Level = level;
            CountAttempts = countAttempts;
        }

        public override string ToString()
        {
            return "Уровень: " + Level + "; Количество попыток: " + CountAttempts;
        }
    }
}
