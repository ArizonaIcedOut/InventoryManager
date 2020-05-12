// Author: Eric Pu
// File Name: Form1.cs
// Project Name: InventoryManager
// Creation Date: March 1, 2020
// Modified Date: April 21, 2020
// Description: An Amazon-themed inventory manager.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class Form1 : Form
    {
        // Inventory storing all the items
        Inventory inventory;

        // File path for the inventory file
        string filePath = "inventory.txt";

        // Dictionary storing index in filtered list as key, and index in actual inventory as value
        Dictionary<int, int> filteredIndex;

        // Stores whether filter is currently active or not
        bool filterActive;

        public Form1()
        {
            InitializeComponent();

            // Adds the Form1_FormClosing function to FormClosing, otherwise function will not execute
            this.FormClosing += Form1_FormClosing;

            // Creates new inventory with file path 
            inventory = new Inventory(filePath);

            // Tries to load the inventory
            // if it fails, a message box is displayed and form is closed 
            try { inventory.LoadInventory(); }
            catch
            {
                MessageBox.Show("ERROR: Inventory file not found.");
                System.Windows.Forms.Application.Exit();
            }

            // Adds each item in the inventory to the list box
            for (int i = 0; i < inventory.items.Count; ++i)
            {
                itemListBox.Items.Add(inventory.items[i].Display());
            }

            // Sets filter to inactive
            filterActive = false;

            // Creates new dictionary for filteredIndex
            filteredIndex = new Dictionary<int, int>();

            // Adds the 3 possible types to each combo box, sets the drop down style to drop down list, and sets default type to Movie
            searchTypeComboBox.Items.AddRange(new string[] { "Movie", "Game", "Book" });
            searchTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            searchTypeComboBox.SelectedItem = "Movie";

            filterTypeComboBox.Items.AddRange(new string[] { "Movie", "Game", "Book" });
            filterTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            filterTypeComboBox.SelectedItem = "Movie";

            addTypeComboBox.Items.AddRange(new string[] { "Movie", "Game", "Book" });
            addTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            addTypeComboBox.SelectedItem = "Movie";

            infoTypeComboBox.Items.AddRange(new string[] { "Movie", "Game", "Book" });
            infoTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            infoTypeComboBox.SelectedItem = "Movie";

            // Sets selected index to 0 (with way program is designed, an item must be selected to function as intended)
            itemListBox.SelectedIndex = 0;

            // Adds the possible platforms and genres to each corresponding combo box
            searchPlatformComboBox.Items.AddRange(inventory.platformsDict[(string)searchTypeComboBox.SelectedItem].ToArray());
            infoPlatformComboBox.Items.AddRange(inventory.platformsDict[(string)infoTypeComboBox.SelectedItem].ToArray());
            addPlatformComboBox.Items.AddRange(inventory.platformsDict[(string)addTypeComboBox.SelectedItem].ToArray());
            filterPlatformComboBox.Items.AddRange(inventory.platformsDict[(string)filterTypeComboBox.SelectedItem].ToArray());

            infoGenreComboBox.Items.AddRange(inventory.genresDict[(string)infoTypeComboBox.SelectedItem].ToArray());
            addGenreComboBox.Items.AddRange(inventory.genresDict[(string)infoTypeComboBox.SelectedItem].ToArray());

            // Sets drop down style to drop down list
            searchPlatformComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            filterPlatformComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Description: Functionality for search button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchBtn_Click(object sender, EventArgs e)
        {
            // Creates nullable int searchedItemIndex, and sets it to null
            int? searchedItemIndex = null;

            // Tries to find item, and if there is an error, shows a message box with said error
            try
            {
                // Checks if filter is active or not
                if (!filterActive)
                {
                    // If filter is not active, the item is searched using FindItem function, using parameters from the boxes
                    searchedItemIndex = inventory.FindItem((string)searchTypeComboBox.SelectedItem, searchTitleTxt.Text, (string)searchPlatformComboBox.SelectedItem);
                }
                else
                {
                    // If filter is active, item is searched using FindFilteredItem
                    searchedItemIndex = inventory.FindItem(filteredIndex, (string)searchTypeComboBox.SelectedItem, 
                        searchTitleTxt.Text, (string)searchPlatformComboBox.SelectedItem);
                }

                // If the searched item index is null (not found), tells the user that in a message box
                // Otherwise, it changes the list box index to the index of item found
                if (searchedItemIndex == null) MessageBox.Show("Item not found.");
                else itemListBox.SelectedIndex = (int)searchedItemIndex;
            }
            catch (Exception exception)
            {
                MessageBox.Show(string.Format("ERROR: ITEM NOT FOUND.\n{0}", exception.Message));
            }
        }

        /// <summary>
        /// Description:: Code that executes when the selected index of the list box changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Code only executes when index is valid (-1 is used as an "empty" index, but breaks this code)
            if (itemListBox.SelectedIndex != -1)
            {
                // If the list box is empty, function ends
                if (itemListBox.Items.Count == 0) return;

                // Creates a new item 
                Item item = new Item();

                // If filter is not active, item is set to the currently selected inventory item
                // Otherwise, item is set as the corresponding filtered item (using filteredIndex dictionary)
                if (!filterActive) item = inventory.items[itemListBox.SelectedIndex];
                else item = inventory.items[filteredIndex[itemListBox.SelectedIndex]];

                // Changes the selected item type in other combo boxes to what is currently selected
                addTypeComboBox.SelectedItem = item.type;
                infoTypeComboBox.SelectedItem = item.type;

                // Sets text boxes to attributes of the item
                currTitleTxt.Text = item.title;
                currCostTxt.Text = Convert.ToString(item.cost);
                currReleasedTxt.Text = Convert.ToString(item.releaseYear);

                // Clears all platform and genre combo boxes
                addPlatformComboBox.Items.Clear();
                searchPlatformComboBox.Items.Clear();
                infoPlatformComboBox.Items.Clear();
                filterPlatformComboBox.Items.Clear();
                addGenreComboBox.Items.Clear();
                infoGenreComboBox.Items.Clear();

                // Changes combo box options to genres/platforms for corresponding item type
                addPlatformComboBox.Items.AddRange(inventory.platformsDict[item.type].ToArray());
                infoPlatformComboBox.Items.AddRange(inventory.platformsDict[item.type].ToArray());
                searchPlatformComboBox.Items.AddRange(inventory.platformsDict[item.type].ToArray());
                filterPlatformComboBox.Items.AddRange(inventory.platformsDict[item.type].ToArray());
                addGenreComboBox.Items.AddRange(inventory.genresDict[item.type].ToArray());
                infoGenreComboBox.Items.AddRange(inventory.genresDict[item.type].ToArray());

                // Sets selected genre/platform to the item's genre/platform
                infoGenreComboBox.SelectedItem = Convert.ToString(item.genre);
                infoPlatformComboBox.SelectedItem = Convert.ToString(item.platform);

                // Changes text labels based on item type
                switch (item.type)
                {
                    case "Movie":
                        {
                            // Creates a new Movie with properties of the currently selected item
                            Movie movie = (Movie)item;

                            // Changes type-specific labels and text boxes to corresponding attributes
                            typeSpecific1Lbl.Text = "Director:";
                            typeSpecific2Lbl.Text = "Duration:";
                            currTypeSpecific1Txt.Text = movie.director;
                            currTypeSpecific2Txt.Text = Convert.ToString(movie.duration);
                            break;
                        }
                    case "Book":
                        {
                            Book book = (Book)item;
                            typeSpecific1Lbl.Text = "Author:";
                            typeSpecific2Lbl.Text = "Publisher:";
                            currTypeSpecific1Txt.Text = book.author;
                            currTypeSpecific2Txt.Text = book.publisher;
                            break;
                        }
                    case "Game":
                        {
                            Game game = (Game)item;
                            typeSpecific1Lbl.Text = "Developer:";
                            typeSpecific2Lbl.Text = "IGN Score:";
                            currTypeSpecific1Txt.Text = game.developer;
                            currTypeSpecific2Txt.Text = Convert.ToString(game.ignScore);
                            break;
                        }
                }
            }
        }

        /// <summary>
        /// Description: Executes when the delete button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delBtn_Click(object sender, EventArgs e)
        {
            // If the list box has no items in it, function ends
            if (itemListBox.Items.Count == 0) return;

            // Creates int pastIndex as the initial index selected
            int pastIndex = itemListBox.SelectedIndex;

            // If the filter is active, the item at the filtered index is removed
            // Otherwise, the item at the selected index is removed
            if (filterActive)
            {
                inventory.items.RemoveAt(filteredIndex[pastIndex]);

                // Updates the filter
                UpdateFilter();
            }
            else
            {
                // Removes the item in the list box at the past index
                itemListBox.Items.RemoveAt(pastIndex);

                // Removes item in the inventory at the past index
                inventory.items.RemoveAt(pastIndex);
            }

            // If the past index was not 0, decrements selected index by 1
            // Otherwise, if there are items left in inventory, selected index is set to 0
            if (pastIndex != 0) itemListBox.SelectedIndex = pastIndex - 1;
            else if (itemListBox.Items.Count > 0) itemListBox.SelectedIndex = 0; 
        }

        /// <summary>
        /// Description: Executes whenever type combo box in search menu changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clears the platforms combo box 
            searchPlatformComboBox.Items.Clear();

            // Adds the list of possible platforms to the combo box
            searchPlatformComboBox.Items.AddRange(inventory.platformsDict[(string)searchTypeComboBox.SelectedItem].ToArray());
        }

        /// <summary>
        /// Description: Executes whenever the type combo box in add item screen changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Switch statement for each type of item
            switch (itemListBox.Items[itemListBox.SelectedIndex])
            {
                case "Movie":
                    {
                        // Changes the type specific label text according to item type
                        addTypeSpecific1Lbl.Text = "Director:";
                        addTypeSpecific2Lbl.Text = "Duration:";
                        break;
                    }
                case "Game":
                    {
                        addTypeSpecific1Lbl.Text = "Developer:";
                        addTypeSpecific2Lbl.Text = "IGN Score:";
                        break;
                    }
                case "Book":
                    {
                        addTypeSpecific1Lbl.Text = "Author:";
                        addTypeSpecific2Lbl.Text = "Publisher:";
                        break;
                    }
            }
        }

        /// <summary>
        /// Description: Executed when the save changes button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            // If there are no items in the list box, function ends
            if (itemListBox.Items.Count == 0) return;

            // Creates ints pastItemCount and index, as number of items in list box and selected index
            int pastItemCount = itemListBox.Items.Count;
            int index = itemListBox.SelectedIndex;

            // Creates variables for new attributes of item
            string newType = (string)infoTypeComboBox.SelectedItem;
            string title = currTitleTxt.Text;
            double cost;
            string genre = infoGenreComboBox.Text;
            string platform = infoPlatformComboBox.Text;
            int releaseYear;

            // Attempts to convert user input
            // If TryParse fails, message box is shown with error
            if (!Double.TryParse(currCostTxt.Text, out cost))
            {
                MessageBox.Show("ERROR: Invalid cost.");
                return;
            }
            if (!Int32.TryParse(currReleasedTxt.Text, out releaseYear))
            {
                MessageBox.Show("ERROR: Invalid release year.");
                return;
            }

            // Switch statement for each type of item
            switch (newType)
            {
                case "Movie":
                    {
                        // Creates variables for type specific attributes
                        string director = currTypeSpecific1Txt.Text;
                        int duration;

                        // Attempts to convert duration input to integer
                        // If it fails, shows message box with error
                        if (!Int32.TryParse(currTypeSpecific2Txt.Text, out duration))
                        {
                            MessageBox.Show("ERROR: Invalid duration. (Please use whole minutes.)");
                            return;
                        }

                        // If filter is active, change is made to item at filtered index
                        // Otherwise, change is made to item at selected index
                        if (filterActive) inventory.items[filteredIndex[index]] = new Movie(newType, title, cost, genre, platform, releaseYear, director, duration);
                        else inventory.items[index] = new Movie(newType, title, cost, genre, platform, releaseYear, director, duration);
                        break;
                    }
                case "Game":
                    {
                        string developer = currTypeSpecific1Txt.Text;
                        double ignScore;

                        if (!Double.TryParse(currTypeSpecific2Txt.Text, out ignScore))
                        {
                            MessageBox.Show("ERROR: Invalid IGN score. (IGN scores are single digit decimals from 0 to 10.");
                            return;
                        }

                        if (filterActive) inventory.items[filteredIndex[index]] = new Game(newType, title, cost, genre, platform, releaseYear, developer, ignScore);
                        else inventory.items[index] = new Game(newType, title, cost, genre, platform, releaseYear, developer, ignScore);
                        break;
                    }
                case "Book":
                    {
                        string author = currTypeSpecific1Txt.Text;
                        string publisher = currTypeSpecific2Txt.Text;

                        if (filterActive) inventory.items[filteredIndex[index]] = new Book(newType, title, cost, genre, platform, releaseYear, author, publisher);
                        else inventory.items[index] = new Book(newType, title, cost, genre, platform, releaseYear, author, publisher);
                        break;
                    }
            }

            // Updates possible platforms and genres for item type
            inventory.UpdatePlatforms(newType, platform);
            inventory.UpdateGenres(newType, genre);

            // Changes item in list box according to changes
            itemListBox.Items[index] = inventory.items[index].Display();

            // If filter is active, filter is updated 
            if (filterActive)
            {
                UpdateFilter();

                // If number of items in list box has not changed, index stays the same
                // Otherwise, if items still exist in list box, index is decremented
                if (pastItemCount == itemListBox.Items.Count) itemListBox.SelectedIndex = index;
                else if (itemListBox.Items.Count > 0) itemListBox.SelectedIndex = index - 1;
            }

        }

        /// <summary>
        /// Description: Executes whenever the selected index in type combo box on add item screen is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Switch statement for each item type
            switch (addTypeComboBox.SelectedItem)
            {
                case "Movie":
                    {
                        // Changes type specific labels according to item type
                        addTypeSpecific1Lbl.Text = "Director:";
                        addTypeSpecific2Lbl.Text = "Duration:";
                        break;
                    }
                case "Book":
                    {
                        addTypeSpecific1Lbl.Text = "Author:";
                        addTypeSpecific2Lbl.Text = "Publisher:";
                        break;
                    }
                case "Game":
                    {
                        addTypeSpecific1Lbl.Text = "Developer:";
                        addTypeSpecific2Lbl.Text = "IGN Score:";
                        break;
                    }
            }

            // Clears platform and genre combo boxes
            // Adds list of possible genres/platforms to combo boxes
            // Sets selected index to 0 for both combo boxes
            addPlatformComboBox.Items.Clear();
            addPlatformComboBox.Items.AddRange(inventory.platformsDict[(string)addTypeComboBox.SelectedItem].ToArray());
            addPlatformComboBox.SelectedIndex = 0;

            addGenreComboBox.Items.Clear();
            addGenreComboBox.Items.AddRange(inventory.genresDict[(string)addTypeComboBox.SelectedItem].ToArray());
            addGenreComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Description: Executes whenever the add new item button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBtn_Click(object sender, EventArgs e)
        {
            // If there is an error, code in catch is executed
            try
            {
                // Creates int pastItemsCount and pastIndex as past number of items and selected index
                int pastItemsCount = itemListBox.Items.Count;
                int pastIndex = itemListBox.SelectedIndex;

                // Creates variables for attributes of item
                string type = (string)addTypeComboBox.SelectedItem;
                string title = addTitleBox.Text;
                double cost;
                string genre = addGenreComboBox.Text;
                string platform = addPlatformComboBox.Text;
                int releaseYear;

                // Attempts to convert cost and release year to double and integer respectively
                // If it is not possible, a message box shows an error
                if (!Double.TryParse(addCostBox.Text, out cost))
                {
                    MessageBox.Show("ERROR: Invalid cost.");
                    return;
                }
                if (!Int32.TryParse(addReleasedBox.Text, out releaseYear))
                {
                    MessageBox.Show("ERROR: Invalid release year.");
                    return;
                }

                // Switch for adding the item, based on the type it is
                switch (addTypeComboBox.SelectedItem)
                {
                    case "Movie":
                        {
                            // Creates type specific attributes director and duration
                            string director = addTypeSpecific1Box.Text;
                            int duration;

                            // If duration cannot be converted, error is shown and item is not added
                            if (!Int32.TryParse(addTypeSpecific2Box.Text, out duration))
                            {
                                MessageBox.Show("ERROR: Invalid duration. (Please use whole minutes.)");
                                return;
                            }

                            // Adds the new item with the given attributes
                            AddItem(new Movie(type, title, cost, genre, platform, releaseYear, director, duration));
                            break;
                        }
                    case "Game":
                        {
                            string developer = addTypeSpecific1Box.Text;
                            double ignScore;

                            if (!Double.TryParse(addTypeSpecific2Box.Text, out ignScore))
                            {
                                MessageBox.Show("ERROR: Invalid IGN score. (IGN scores are single digit decimals from 0 to 10.");
                                return;
                            }

                            AddItem(new Game(type, title, cost, genre, platform, releaseYear, developer, ignScore));
                            break;
                        }
                    case "Book":
                        {
                            string author = addTypeSpecific1Box.Text;
                            string publisher = addTypeSpecific2Box.Text;

                            AddItem(new Book(type, title, cost, genre, platform, releaseYear, author, publisher));
                            break;
                        }
                }

                // Sets the list box index to the past index (list box index automatically changes to -1 when items are changed, this prevents that)
                itemListBox.SelectedIndex = pastIndex;

                // If the number of items is different to before item change (only possible if filter is active), selected index is incremented
                if (itemListBox.Items.Count != pastItemsCount) ++itemListBox.SelectedIndex;
            }
            // If there is any error, a message box is shown with said error
            catch (Exception exception)
            {
                MessageBox.Show("ERROR: {0}", exception.Message);
            }

        }

        /// <summary>
        /// Description: Executes when the save button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Saves the inventory
            inventory.SaveInventory();
        }

        /// <summary>
        /// Description: Executes whenever the type combo box for an item's info is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void infoTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Changes attribute labels depending on the item type
            switch (infoTypeComboBox.SelectedItem)
            {
                case "Movie":
                    {
                        typeSpecific1Lbl.Text = "Director:";
                        typeSpecific2Lbl.Text = "Duration:";
                        break;
                    }
                case "Book":
                    {
                        typeSpecific1Lbl.Text = "Author:";
                        typeSpecific2Lbl.Text = "Publisher:";
                        break;
                    }
                case "Game":
                    {
                        typeSpecific1Lbl.Text = "Developer:";
                        typeSpecific2Lbl.Text = "IGN Score:";
                        break;
                    }
            }

            // Clears the platform and genre boxes, then adds the list of possible genres/platforms and resets them
            infoPlatformComboBox.Items.Clear();
            infoPlatformComboBox.Items.AddRange(inventory.platformsDict[(string)infoTypeComboBox.SelectedItem].ToArray());
            infoPlatformComboBox.SelectedIndex = 0;

            infoGenreComboBox.Items.Clear();
            infoGenreComboBox.Items.AddRange(inventory.genresDict[(string)infoTypeComboBox.SelectedItem].ToArray());
            infoGenreComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Description: Executes when the filtered item type combo box is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void filterTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clears the combo box options
            filterPlatformComboBox.Items.Clear();
            
            // Adds all the possible platforms for that item type to the combo box
            filterPlatformComboBox.Items.AddRange(inventory.platformsDict[(string)filterTypeComboBox.SelectedItem].ToArray());
        }

        /// <summary>
        /// Description: Executes when the filtered title combo box is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void filterTitleTxt_TextChanged(object sender, EventArgs e)
        {
            // Updates the filter
            UpdateFilter();
        }

        /// <summary>
        /// Description: Executed when the combo box for filtered platform is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void filterPlatformComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Updates the filter
            UpdateFilter();
        }

        /// <summary>
        /// Description: Executed when the program is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Creates message box asking if user wants to save changes to ivnentory
            if (MessageBox.Show("Save changes to inventory?", "Amazon Inventory Manager",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // If they press yes, inventory is saved
                inventory.SaveInventory();
            }
        }

        /// <summary>
        /// Description: Executed when the filter button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void filterBtn_Click(object sender, EventArgs e)
        {
            // If the filter is inactive, filter is activated
            // Otherwise, filter is deactivated
            if (!filterActive)
            {
                // Filter set to active
                filterActive = true;

                // Updates filter
                UpdateFilter();

                // Changes the text on the button to "Disable Filter"
                filterBtn.Text = "Disable Filter";
            }
            else
            {
                // Wipes the list box
                itemListBox.Items.Clear();

                // Loops through each item in the inventory
                for (int i = 0; i < inventory.items.Count; ++i)
                {
                    // Adds the item t othe list box
                    itemListBox.Items.Add(inventory.items[i].Display());
                }

                // Sets filter to inactive
                filterActive = false;

                // Changes text on button
                filterBtn.Text = "Enable Filter";
            }
        }

        /// <summary>
        /// Pre: n/a
        /// Post: n/a
        /// Description: Updates the filter
        /// </summary>
        private void UpdateFilter()
        {
            // Code only executes if filter is active
            if (filterActive)
            {
                // Creates new dictionary of filtered indexes
                filteredIndex = new Dictionary<int, int>();

                // Filters the inventory with user's input
                List<int> filteredList = inventory.FilterItems((string)filterTypeComboBox.SelectedItem, filterTitleTxt.Text, (string)filterPlatformComboBox.SelectedItem);

                // Clears the list box
                itemListBox.Items.Clear();

                // Loops through each filtered item
                for (int i = 0; i < filteredList.Count; ++i)
                {
                    // Adds each filtered item to the list box
                    itemListBox.Items.Add(inventory.items[filteredList[i]].Display());

                    // Adds the index to the dictionary of filtered indexes
                    filteredIndex.Add(i, filteredList[i]);
                }

                // Resets selected index to 0, unless there are 0 items (prevents crashing)
                if (itemListBox.Items.Count != 0) itemListBox.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Pre: n/a
        /// Post: n/a
        /// Description: Adds an item to the inventory.
        /// </summary>
        /// <param name="newItem"></param>
        private void AddItem(Item newItem)
        {
            // if the filter is active, the item is inserted in inventory at the filtered index and filter is updated
            // Otherwise, filter is inserted at selected index in inventory and list box
            if (filterActive)
            {
                inventory.items.Insert(filteredIndex[itemListBox.SelectedIndex] + 1, newItem);
                UpdateFilter();
            }
            else
            {
                inventory.items.Insert(itemListBox.SelectedIndex + 1, newItem);
                itemListBox.Items.Insert(itemListBox.SelectedIndex + 1, newItem.Display());
            }

            // Updates the platforms and genres for inventory
            inventory.UpdatePlatforms(newItem.type, newItem.platform);
            inventory.UpdateGenres(newItem.type, newItem.genre);
        }
    }
}
