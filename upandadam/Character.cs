using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    enum Difficulty
    {
        Easy = 0,
        Medium = 1,
        Hard = 2,
        Extreme = 3
    }

    /// <summary>
    /// Character class will hold the default stats for difficulty level
    /// as well as current stats for character in-progress.
    /// </summary>
    class Character
    {
        // Dictionaty of character stats and values for difficulty levels
        public IDictionary<string, double> DefaultStatsEasy { get; private set; }
        public IDictionary<string, double> DefaultStatsMedium { get; private set; }
        public IDictionary<string, double> DefaultStatsHard { get; private set; }
        public IDictionary<string, double> DefaultStatsExtreme { get; private set; }

        // Stats for the current character
        public IDictionary<string, double> CurrentStats { get; private set; }

        // Queue for holding current list of item tasks
        public Queue<Task> ItemTaskQueue { get; private set; }

        public Character()
        {
            this.DefaultStatsEasy = new Dictionary<string, double>();
            this.DefaultStatsMedium = new Dictionary<string, double>();
            this.DefaultStatsHard = new Dictionary<string, double>();
            this.DefaultStatsExtreme = new Dictionary<string, double>();

            this.CurrentStats = new Dictionary<string, double>();

            this.ItemTaskQueue = new Queue<Task>();
        }

        public void SetDefaultDifficultyStats(string difficultyLevel, string statName, double statValue)
        {
            switch (difficultyLevel)
            {
                case "difficulty_easy":
                    this.DefaultStatsEasy.Add(statName, statValue);
                    break;
                case "difficulty_medium":
                    this.DefaultStatsMedium.Add(statName, statValue);
                    break;
                case "difficulty_hard":
                    this.DefaultStatsHard.Add(statName, statValue);
                    break;
                case "difficulty_extreme":
                    this.DefaultStatsExtreme.Add(statName, statValue);
                    break;
            }
        }

        public void PrintAll()
        {
            Console.WriteLine("EASY:");
            foreach(KeyValuePair<string, double> kvp in this.DefaultStatsEasy)
            {
                Console.WriteLine("\t - " + kvp.Key + ": " + kvp.Value);
            }
            Console.WriteLine("MEDIUM:");
            foreach (KeyValuePair<string, double> kvp in this.DefaultStatsMedium)
            {
                Console.WriteLine("\t - " + kvp.Key + ": " + kvp.Value);
            }
            Console.WriteLine("HARD:");
            foreach (KeyValuePair<string, double> kvp in this.DefaultStatsHard)
            {
                Console.WriteLine("\t - " + kvp.Key + ": " + kvp.Value);
            }
            Console.WriteLine("EXTREME:");
            foreach (KeyValuePair<string, double> kvp in this.DefaultStatsExtreme)
            {
                Console.WriteLine("\t - " + kvp.Key + ": " + kvp.Value);
            }
        }
    }
}
