// Author: Eric Pu
// File Name: Game.cs
// Project Name: InventoryManager
// Creation Date: March 1, 2020
// Modified Date: April 21, 2020
// Description: Class of Game item type, inheriting from Item class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Description: Class of Game item type, inherited from Item class
/// </summary>
namespace InventoryManager
{
    class Game : Item
    {
        // Game has two unique attributes: developer (string) and IGN score (double from 0-10)
        public string developer { get; set; }
        public double ignScore { get; set; }

        // Initializes the Game with item's parameters, inheriting from Item
        public Game(string type, string title, double cost, string genre, string platform, int releaseYear, string developer, double ignScore) 
            : base(type, title, cost, genre, platform, releaseYear)
        {
            this.developer = developer;
            this.ignScore = ignScore;
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
                type, title, Convert.ToString(cost), genre, platform, Convert.ToString(releaseYear), developer, Convert.ToString(ignScore));
        }
    }
}
