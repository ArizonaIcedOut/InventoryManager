// Author: Eric Pu
// File Name: Inventory.cs
// Project Name: InventoryManager
// Creation Date: March 1, 2020
// Modified Date: April 21, 2020
// Description: Class containing core functionality of inventory

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace InventoryManager
{
    class Inventory
    {
        // The list of items being stored
        public List<Item> items;

        // File path of the inventory.txt
        public string filePath;

        // List of different types of items
        public List<Type> itemTypes;

        // Dictionaries for storing information about the inventory
        public Dictionary<string, Type> itemDict;
        public Dictionary<string, List<string>> platformsDict;
        public Dictionary<string, List<string>> genresDict;

        public Inventory(string filePath)
        {
            // Creates a new list of items
            this.items = new List<Item>();

            // Sets file path to filePath parameter 
            this.filePath = filePath;

            // Creates list of the three item types (movie, game, book)
            itemTypes = new List<Type> { typeof(Movie), typeof(Game), typeof(Book) };

            // Creates a new dictionary of item types (key is name of item type, type is actual type of item)
            itemDict = new Dictionary<string, Type>();
            foreach (Type type in itemTypes)
            {
                itemDict.Add(type.Name, type);
            }

            // Creates an empty list of strings for each item type and genre, storing each platform
            platformsDict = new Dictionary<string, List<string>>
            {
                {"Movie", new List<string>()},
                {"Game", new List<string>()},
                {"Book", new List<string>()}
            };
            genresDict = new Dictionary<string, List<string>>
            {
                {"Movie", new List<string>()},
                {"Game", new List<string>()},
                {"Book", new List<string>()}
            };
        }

        /// <summary>
        /// Pre: n/a
        /// Post: n/a
        /// Description: Loads the inventory from the inventory.txt file
        /// </summary>
        public void LoadInventory()
        {
            // Creates StreamReader with the given file path
            StreamReader sr = new StreamReader(filePath);

            try
            {
                // Loops through every line of the file path
                for (int i = 0; i < File.ReadAllLines(filePath).Length; ++i)
                {
                    try
                    {
                        // Splits the line into an array of strings
                        string[] itemArr = sr.ReadLine().Split(',');

                        // Type is first element in itemArr
                        string type = itemArr[0];
                        string title = itemArr[1];
                        string genre = itemArr[3];
                        string platform = itemArr[4];
                        double cost;
                        int releaseYear;

                        // Checks if there are the correct number of elements in itemArr for the given type
                        if (itemArr.Length != itemDict[type].GetConstructors()[0].GetParameters().Length)
                        {
                            // If not, an error message is printed and loop continues on to next item
                            Console.WriteLine("ERROR: Line {0}, insufficient item information.", i);
                            continue;
                        }

                        // Tries to convert second element into a double. If it is invalid, error message is printed and loop continues.
                        if (!Double.TryParse(itemArr[2], out cost))
                        {
                            Console.WriteLine("ERROR: Line {0}, invalid cost.", i);
                            continue;
                        }
                        // Attempts to convert release year
                        if (!Int32.TryParse(itemArr[5], out releaseYear))
                        {
                            Console.WriteLine("ERROR: Line {0}, invalid release year.", i);
                            continue;
                        }

                        // If the list of platforms/genres does not already contain the element, it is added
                        if (!platformsDict[type].Contains(platform))
                        {
                            platformsDict[type].Add(platform); 
                        }
                        if (!genresDict[type].Contains(genre))
                        {
                            genresDict[type].Add(genre);
                        }

                        // Switch with cases for each type of item
                        switch (type)
                        {
                            case "Movie":
                                {
                                    string director = itemArr[6];
                                    int duration;

                                    // Attempts to convert duration to integer
                                    if (!Int32.TryParse(itemArr[7], out duration))
                                    {
                                        Console.WriteLine("ERROR: Line {0}, invalid duration. (Please use whole minutes)", i);
                                        break;
                                    }

                                    // Adds the item with the given elements
                                    items.Add(new Movie(type, title, cost, genre, platform, releaseYear, director, duration));
                                    break;
                                }
                            case "Game":
                                {
                                    string developer = itemArr[6];
                                    double ignScore;

                                    if (!Double.TryParse(itemArr[7], out ignScore))
                                    {
                                        Console.WriteLine("ERROR: Line {0}, invalid IGN score. (IGN scores are single digit decimals from 0 to 10.)", i);
                                        break;
                                    }

                                    items.Add(new Game(type, title, cost, genre, platform, releaseYear, developer, ignScore));
                                    break;
                                }
                            case "Book":
                                {
                                    string author = itemArr[6];
                                    string publisher = itemArr[7];

                                    items.Add(new Book(type, title, cost, genre, platform, releaseYear, author, publisher));
                                    break;
                                }
                            default:
                                {
                                    // If the item type is invalid, message is printed and loop continues
                                    Console.WriteLine("ERROR: INVALID ITEM TYPE.");
                                    break;
                                }
                        }
                    }
                    // If there is any other error, it is printed
                    catch (Exception e)
                    {
                        Console.WriteLine("ERROR: Line {0}, invalid item.", i);
                        Console.WriteLine(e.Message);
                    }
                }
            }
            // If there is an error, a message is printed in console
            catch (Exception e)
            {
                Console.WriteLine("ERROR: File cannot be read.");
                Console.WriteLine(e.Message);
            }

            // Closes the StreamReader
            sr.Close();
        }

        public void SaveInventory()
        {
            // Wipes the inventory.txt file
            File.WriteAllText(filePath, "");

            // Creates a new StreamWriter
            StreamWriter sw = new StreamWriter(filePath);

            // Writes the string for each item in the inventory
            for (int i = 0; i < items.Count; ++i)
            {
                sw.WriteLine(items[i].Display());
            }

            // Closes the StreamWriter
            sw.Close();
        }

        /// <summary>
        /// Pre: n/a
        /// Post: n/a
        /// Description: Deletes the item at the given index
        /// </summary>
        /// <param name="index"></param>
        public void DeleteItem(int index)
        {
            // Removes the item at the given index
            try
            {
                items.RemoveAt(index);
            }
            catch (Exception e)
            {
                // If the index is invalid, error is printed
                Console.WriteLine("ERROR: Item not found.");
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Pre: strings type, title, platform as values being searched for
        /// Post: Returns index of matching item as nullable int
        /// Description: Searches for an item in the inventory with given parameters
        /// </summary>
        /// <param name="type"></param>
        /// <param name="title"></param>
        /// <param name="platform"></param>
        /// <returns></returns>
        public int? FindItem(string type, string title, string platform)
        {
            // Loops through every item in the inventory
            for (int i = 0; i < items.Count; ++i)
            {
                // Checks if the item contains the given type, title, and platform
                if (CaseInsensitiveContains(items[i].type, type) && CaseInsensitiveContains(items[i].title, title) && CaseInsensitiveContains(items[i].platform, platform))
                {
                    // If all three match, the matching index is returned
                    return i;
                }
            }

            // If no match is found, a null int is returned
            return null;
        }

        /// <summary>
        /// Pre: strings type, title, platform as values being searched for
        /// Post: Returns index of matching item as nullable int
        /// Description: Searches for an item in the inventory with given parameters 
        /// </summary>
        /// <param name="filteredIndex"></param>
        /// <param name="type"></param>
        /// <param name="title"></param>
        /// <param name="platform"></param>
        /// <returns></returns>
        public int? FindItem(Dictionary<int, int> filteredIndex, string type, string title, string platform)
        {
            // Loops through every item in the filtered inventory
            for (int i = 0; i < filteredIndex.Count; ++i)
            {
                // Checks if type, title, and platform each contain search query
                if (CaseInsensitiveContains(items[filteredIndex[i]].type, type) && 
                    CaseInsensitiveContains(items[filteredIndex[i]].title, title) && 
                    CaseInsensitiveContains(items[filteredIndex[i]].platform, platform))
                {
                    // Returns the index of found item
                    return i;
                }
            }

            // If no match is found, returns a null int
            return null;
        }

        /// <summary>
        /// Pre: string type, title, platform as filtered attributes
        /// Post: List of integers containing indexes of all items that meet filter requirements
        /// </summary>
        /// <param name="type"></param>
        /// <param name="title"></param>
        /// <param name="platform"></param>
        /// <returns></returns>
        public List<int> FilterItems(string type, string title, string platform)
        {
            // Creates new list of integers
            List<int> filteredList = new List<int>();

            // Loops in each item in the inventory
            for (int i = 0; i < items.Count; ++i)
            {
                // Checks if it matches the filter requirements
                if (CaseInsensitiveContains(items[i].type, type) && CaseInsensitiveContains(items[i].title, title) && CaseInsensitiveContains(items[i].platform, platform))
                {
                    // If it does, adds the item's index to the list
                    filteredList.Add(i);
                }
            }

            // Returns the list of indexes
            return filteredList;
        }

        /// <summary>
        /// Pre: Strings for item's type and platform
        /// Post: n/a
        /// Description: Updates the list of platform names, when given a new item
        /// </summary>
        /// <param name="itemType"></param>
        /// <param name="itemPlatform"></param>
        public void UpdatePlatforms(string itemType, string itemPlatform)
        {
            // If the specific item type's list of platforms does not contain the new platform, it is added to the list (through the dictionary)
            if (!platformsDict[itemType].Contains(itemPlatform))
            {
                platformsDict[itemType].Add(itemPlatform);
            }
        }

        /// <summary>
        /// Pre: Strings for item's type and platform
        /// Post: n/a
        /// Description: Updates the listt of genre names, when given a new item
        /// </summary>
        /// <param name="itemType"></param>
        /// <param name="itemGenre"></param>
        public void UpdateGenres(string itemType, string itemGenre)
        {
            // If the specific item type's list of genres does not contain the new genre, it is added to the list
            if (!genresDict[itemType].Contains(itemGenre))
            {
                genresDict[itemType].Add(itemGenre);
            }
        }

        /// <summary>
        /// Pre: string value (text checked if contained in string text), string text (text checked if value is contained in)
        /// Post: Returns whether value is contained in text or not
        /// </summary>
        /// <param name="text"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool CaseInsensitiveContains(string text, string value)
        {
            // If value is empty, returns true (this allows user to leave fields blank)
            if (String.IsNullOrEmpty(value)) return true;

            // Creates a StringComparison which ignores cases
            StringComparison stringComparison = StringComparison.CurrentCultureIgnoreCase;

            // If the index of value in text >= 0 (meaning there is a match), the index is returned
            return text.IndexOf(value, stringComparison) >= 0;
        }
    }
}
