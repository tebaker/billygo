using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Character
    {
        // Dictionaty of character stats and their default values
        public IDictionary<string, double> Stats { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sleepiness">Effects ability to take up and preform tasks quickly</param>
        /// <param name="energy">Effects ability overall health, curbed by consumables</param>
        /// <param name="hunger">Effects stress and overall health</param>
        /// <param name="happiness">Effects mental health and overall stats</param>
        /// <param name="stress">Effects all stats</param>
        /// <param name="speed">Effects how quickly the character moves and preforms tasks</param>
        /// <param name="bladderFullness">How badly the character needs to pee</param>
        /// <param name="hygiene">Affected by player showers and effects social standing</param>
        /// <param name="health">Overall health of the character</param>
        /// <param name="socialStanding">How the character is seen outside the appartment</param>
        /// <param name="mentalHealth">Overall mental health of the character</param>
        public Character(
            double sleepiness,
            double energy,
            double hunger,
            double happiness,
            double stress,
            double speed,
            double bladderFullness,
            double hygiene,
            double health,
            double socialStanding,
            double mentalHealth)
        {
            this.Stats = new Dictionary<string, double>()
            {
                {"Sleepiness", sleepiness},
                {"Energy", energy},
                {"Hunger", hunger},
                {"Happiness", happiness},
                {"Stress", stress},
                {"Speed", speed},
                {"BladderFullness", bladderFullness},
                {"Hygiene", hygiene},
                {"Health", health},
                {"SocialStanding", socialStanding },
                {"MentalHealth", mentalHealth }
            };
        }
    }
}
