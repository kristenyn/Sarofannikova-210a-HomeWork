using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    static class NumberGenerator
    {
        public static int GetRandomNumber(int level)
        {
            Random rand = new Random();
            switch (level)
            {
                case 1:
                    return rand.Next(1, 10);
                case 2:
                    return rand.Next(1, 50);
                case 3:
                    return rand.Next(1, 100);
                default:
                    return -1;
                    break;
            }
        }
    }
}
