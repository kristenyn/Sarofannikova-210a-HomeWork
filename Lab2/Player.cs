using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Player
    {
        public string Name { get; set; } = "";
        public List<GameResult> Results { get; set; }

        public Player(string name)
        {
            Name = name;
            Results = new List<GameResult>();
        }

        public void AddResult(GameResult result)
        {
            Results.Add(result);
        }

        public override string ToString()
        {
            string res = "";
            foreach (GameResult result in Results)
                res += result.ToString() + "\n";
            return res;
        }
    }
}
