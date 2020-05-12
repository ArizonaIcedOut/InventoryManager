// Author: Eric Pu
// File Name: Item.cs
// Project Name: InventoryManager
// Creation Date: March 1, 2020
// Modified Date: April 21, 2020
// Description: Class of Movie item type, inheriting from Item class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    class Movie : Item
    {
        // Movie has two unique attributes: director (string) and duration (integer in minutes)
        public string director { get; set; }
        public int duration { get; set; }

        // Initializes item, inheriting from Item
        public Movie(string type, string title, double cost, string genre, string platform, int releaseYear, string director, int duration) 
            : base(type, title, cost, genre, platform, releaseYear)
        {
            this.director = director;
            this.duration = duration;
        }

        /// <summary>
        /// Pre: n/a
        /// Post: Returns a string with attributes of the item
        /// Description: Generates a string for the item, to be stored in a list of strings
        /// </summary>
        /// <returns></returns>
        public override string Display()
        {
            return string.Format("{0},{1},{2},{3},{4},{5},{6},{7}",
                type, title, Convert.ToString(cost), genre, platform, Convert.ToString(releaseYear), director, Convert.ToString(duration));
        }

    }
}
