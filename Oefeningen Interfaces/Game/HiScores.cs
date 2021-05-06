using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class HiScores
    {
        public HiScores()
        {
            AddEntry("7143", "Arthur");
        }
        public List<string[]> ListHiScores { get; set; } = new List<string[]>();
        public void AddEntry(string newEntry, string name)
        {
            ListHiScores.Add(new string[]{ newEntry,name});
            ListHiScores.Sort((e1, e2) => Convert.ToInt32(e1).CompareTo(Convert.ToInt32(e2)));
        }
        public override string ToString()
        {
            return base.ToString();
            Convert.ToInt32
        }
    }
}
