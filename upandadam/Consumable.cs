using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// TO DO:
///  1) Add cleaning function to pick up broken or destroyed consumables
///  2) Add sounds when adding consumable to 'isHolding' list
///     - If adding LIQUID to consumable, make liquid sounds
///     - If adding FOOD, make slapping sounds, etc...
/// </summary>

namespace WpfApp1
{
    /// <summary>
    /// A consumable is an item that can be eaten by the character
    ///  * A consumable is like Bacon, Eggs, etc.
    ///  * A consumable has properties relating to optimal cooking / eating temperatures
    ///  * A consumable does not have an associated task location
    ///     - ie: can be consumed at any location or while preforming another task
    /// </summary>
    class Consumable : Item
    {
        // Default information about the consumable; set on constructor from XML
        // Current temperature of item in degrees F
        public double CurrentTemp { get; private set; }

        // Temperature for optimal eating
        public double OptimalTemp { get; private set; }

        // Acceptable temperature range for eating
        public double AcceptableRange { get; private set; }

        // How quickly the temp will drop
        public double TempDropoff { get; private set; }

        // Information acquired after player interaction
        // What temp did the consumable reach
        public double MaxTempReached { get; private set; }

        // Overloaded Constructor
        public Consumable(double currentTemp, double optimalTemp, double acceptableRange, double tempDropoff)
        {
            this.CurrentTemp = currentTemp;
            this.OptimalTemp = optimalTemp;
            this.AcceptableRange = acceptableRange;
            this.TempDropoff = tempDropoff;
            this.MaxTempReached = currentTemp; // Max temp starts off at current temp
        }

        /// <summary>
        /// Consuming an item will have several effects for the player
        /// as well as several effects for the score.
        /// </summary>
        /// <returns></returns>
        public double Consume()
        {
            double score = 0.0;

            // Calculating distance between current and optimal temp
            score += Math.Abs(this.CurrentTemp - this.OptimalTemp);

            return score;
        }
    }
}
