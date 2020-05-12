// Author: Eric Pu
// File Name: Item.cs
// Project Name: InventoryManager
// Creation Date: March 1, 2020
// Modified Date: April 21, 2020
// Description: Parent class for items, inherited by Game, Movie, and Book

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    class Item
    {
        // Attributes common to all item types
        public string type { get; set; }
        public string title {get; set;}
        public double cost { get; set; }
        public string genre { get; set; }
        public string platform { get; set; }
        public int releaseYear { get; set; }

        // Empty constructor, so empty items can be created
        public Item()
        {

        }

        // Initializes item with corresponding attributes
        public Item(string type, string title, double cost, string genre, string platform, int releaseYear)
        {
            this.type = type;
            this.title = title;
            this.cost = cost;
            this.genre = genre;
            this.platform = platform;
            this.releaseYear = releaseYear;
        }

        /// <summary>
        /// Pre: n/a
        /// Post: Returns a string with attributes of the item
        /// Description: Generates a string for the item, to be stored in a list of strings
        /// </summary>
        /// <returns></returns>
        public virtual string Display()
        {
            return string.Format("{0},{1},{2},{3},{4},{5}",
                type, title, Convert.ToString(cost), genre, platform, Convert.ToString(releaseYear));
        }
    }
}
