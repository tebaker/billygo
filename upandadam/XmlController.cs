using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.XPath;

namespace WpfApp1
{
    /// <summary>
    /// File loading class - C:\Users\TalonB\source\repos\WpfApp1\WpfApp1\testtext.txt
    /// </summary>
    class XmlController
    {
        public string FilePath { get; set; }

        // Default Constructor
        public XmlController()
        {
            this.FilePath = string.Empty;
        }

        // Overloaded Constructor
        public XmlController(string filePath)
        {
            this.FilePath = filePath;
        }

        public void PopulateItemDetailsFromXml(ref IDictionary<string, Item> itemDict)
        {
            // Helper to parse XML data
            XmlTextReader reader = new XmlTextReader(this.FilePath);

            // Holding temp item to add to dictionary
            Item holdItem = new Item();

            // Flags for specific item information
            bool inItem = false;
            bool inSpriteLocation = false;

            string spriteLoc = string.Empty;
            string holdTagName = string.Empty;

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    // If the case node type is an opening tag
                    case XmlNodeType.Element:
                        // Setting flags to help build items
                        if (reader.Name == "item")
                        {
                            inItem = true;

                            // Creating new Item to hold info
                            holdItem = new Item();
                        }
                        else if (reader.Name == "sprite_location")
                        {
                            inSpriteLocation = true;
                        }

                        // Holding tag name for properly populating item information
                        holdTagName = reader.Name;
                        
                        break;
                    case XmlNodeType.Text: //Display the text in each element.
                        // If in item element, create item
                        if (inSpriteLocation)
                        {
                            spriteLoc = reader.Value;
                            Console.WriteLine("Sprite Location: " + spriteLoc);
                        }
                        else if (inItem)
                        {
                            switch (holdTagName)
                            {
                                case "name":
                                    holdItem.SetName(reader.Value);
                                    break;
                                case "description":
                                    holdItem.SetDescription(reader.Value);
                                    break;
                                case "id":
                                    holdItem.SetID(Int32.Parse(reader.Value));
                                    break;
                                case "mass":
                                    holdItem.SetMass(double.Parse(reader.Value));
                                    break;
                                case "can_break":
                                    if(reader.Value == "true")
                                    {
                                        holdItem.SetCanBreak(true);
                                    }
                                    else
                                    {
                                        holdItem.SetCanBreak(false);
                                    }
                                    break;
                                case "time_to_complete_task":
                                    holdItem.SetTimeToCompleteTask(Int32.Parse(reader.Value));
                                    break;
                                // Default is all the float cases, these will be in the stats interactions dict
                                // This section also holds cook times, temps, and other consumable information
                                default:
                                    holdItem.AddStatsInteractions(holdTagName, Double.Parse(reader.Value));
                                    break;
                            }

                            //Console.WriteLine("Adding:" + holdTagName + ": " + reader.Value);
                        }

                        break;
                    case XmlNodeType.EndElement: //Display the end of the element.
                        // Resetting flags once items have been created
                        if (reader.Name == "item")
                        {
                            // Resetting item flag and adding item to item dictionary
                            inItem = false;

                            // Adding item key as item name and value as item
                            itemDict.Add(holdItem.Name, holdItem);
                        }
                        else if (reader.Name == "sprite_location")
                        {
                            inSpriteLocation = false;
                        }

                        break;
                }
            }
        }

        // Destructor
        ~XmlController()
        {

        }
    }
}
