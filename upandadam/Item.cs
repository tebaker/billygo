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

        // Sprite of the item; from public location + name of item
        //public Sprite ItemSprite { get; private set; }

        // Information on what the item can do
        // If the item can break
        public bool CanBreak { get; private set; }

        // Informatoin relating to item task
        // Time required to complete task
        public int TimeToComplete { get; private set; }

        // Location where character is required to complete task; null if can be complete anywhere.
        //public Loc LocationOfTask { get; private set; }

        // Holding information on how item affects character stats after task complete

    }
}
