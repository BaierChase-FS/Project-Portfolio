using System;
using System.Collections.Generic;

//Chase Baier
//ADF
//10/29/2020
//Synopsis: Menu class hold menu info and displays the menus of the app

namespace Discovery
{
    public class Menu
    {
        //Fields
        private string _title;
        private List<string> _menuItems = new List<string>();

        //Menu Constructor
        public Menu(string[] mainMenu)
        {
            Title = mainMenu[0];
        }
        //Title get and set
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        //Property get and set for menu list
        public List<string> MenuItems
        {
            get { return _menuItems; }
            set { _menuItems = value; }
        }
        //Method to set value to menu List
        public void InIt(string[] items)
        {
            //Add menu items to list to be displayed
            MenuItems.Add(items[1]);
            MenuItems.Add(items[2]);
            MenuItems.Add(items[3]);
        }
        //Method to Display menu List
        public void Display()
        {
            //Header method displays title of menu
            UI.Header(Title);

            //Create a space between the header an the menu display
            Console.WriteLine("\r\n");

            //For loop displays the menu options 
            for (int i =0; i<MenuItems.Count; i++)
            {
                Console.WriteLine($"{MenuItems[i]}");
            }
        }
    }
}
