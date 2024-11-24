using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsUnitTestWelcomeApp
{
    public class IntArray
    {
        public List<int> Array { set; get; } = new();
        public IntArray()
        {
            Random rand = new Random();
            for(int i = 0; i < 10; i++)
                Array.Add(rand.Next(1, 99));
        }

        public void AddRandom()
        {
            Random random = new Random();
            Array.Add(random.Next());
        }
    }
}
