using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    /// <summary>
    /// An item is something physical the character can hold / interact with
    ///  * Items have names and weight
    ///  * Some items can break
    ///  * All items will have an amount of time (in milliseconds)
    ///    required to complete associated task
    ///  * All items will have a sprite associated with them
    ///  * Items can cannot be eaten will have a location associated with them
    ///     - These are locations the character will need to physically go
    ///       to in order to complete a task. ie: toilet, shower, etc.
    ///  * All items will affect Character properties like Energy, Sleepiness, etc.
    ///     - These are stored as a key, value pair in a character dictionary
    /// </summary>
    class Item
    {
        // Information about the item
        // Name of item
        public string Name { get; private set; }

        // Description of the item for fun
        public string Description { get; private set; }

        // ID of the item
        public int ID { get; private set; }

        // Mass, weight of item
        public double Mass { get; private set; }

        // If the item can break
        public bool CanBreak { get; private set; }

        // Time required to complete task
        public int TimeToCompleteTask { get; private set; }

        // The following holds the effect on the player stats
        public IDictionary<string, double> StatsInteractions { get; private set; }

        // Default constructor
        public Item()
        {
            this.StatsInteractions = new Dictionary<string, double>();
        }

        // Setter Methods
        public void SetName(string name)
        {
            this.Name = name;
        }
        public void SetDescription(string description)
        {
            this.Description = description;
        }
        public void SetID(int id)
        {
            this.ID = id;
        }
        public void SetMass(double mass)
        {
            this.Mass = mass;
        }
        public void SetCanBreak(bool canBreak)
        {
            this.CanBreak = canBreak;
        }
        public void SetTimeToCompleteTask(int timeToCompleteTask)
        {
            this.TimeToCompleteTask = timeToCompleteTask;
        }

        // Modifier Methods
        public void AddStatsInteractions(string statName, double interactionAmount)
        {
            this.StatsInteractions.Add(new KeyValuePair<string, double>(statName, interactionAmount));
        }
    }
}
