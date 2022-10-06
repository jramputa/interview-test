using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewTest.Models;

namespace InterviewTest.Controllers
{
    public class Hero : IHero
    {
        public string name { get; set; }
        public string power { get; set; }
        public List<KeyValuePair<string, int>> stats { get; set; }

        /// <summary>
        /// Increment all stats of the hero with a multiple of half the original stat value.
        /// </summary>
        public void evolve()
        {
            if (stats != null && stats.Count > 0)
            {
                for (int i = 0; i < stats.Count; i++)
                {
                    var increment = stats[i].Value + stats[i].Value / 2;
                    stats[i] = new KeyValuePair<string, int>(stats[i].Key, increment);
                }
            }
        }

        /// <summary>
        /// increment all stats of the hero with the supplied statIncrement value.
        /// </summary>
        /// <param name="statIncrease"></param>
        public void evolve(int statIncrease = 5)
        {
            if (stats != null && stats.Count > 0)
            {
                for (int i = 0; i < stats.Count; i++)
                {
                    stats[i] = new KeyValuePair<string, int>(stats[i].Key, stats[i].Value + statIncrease);
                }
            }
        }
    }
}
