// Author: Eric Pu
// File Name: Book.cs
// Project Name: InventoryManager
// Creation Date: March 1, 2020
// Modified Date: April 21, 2020
// Description: Class of Book item type, inheriting from Item class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    class Book : Item
    {
        public string author { get; set; }
        public string publisher { get; set; }

        // Initializes Book with given parameters, inheriting from Item
        public Book(string type, string title, double cost, string genre, string platform, int releaseYear, string author, string publisher) 
            : base(type, title, cost, genre, platform, releaseYear)
        {
            this.author = author;
            this.publisher = publisher;
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
                type, title, Convert.ToString(cost), genre, platform, Convert.ToString(releaseYear), author, publisher);
        }

    }
}
