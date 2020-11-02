using System;

//Chase Baier
//ADF
//10/29/2020
//Synopsis:

namespace Discovery
{
    public class App
    {
        //Fields
        private User _mainUser;

        public App()
        {
            //Set menu values for string array
            string[] mainMenu = new string[] { " Main Menu ", " [1] Login ", " [2] About ", " [0] Exit " };

            //Instantiate Menu object
            Menu menu = new Menu(mainMenu);

            //Call InIt method to set menu list options
            menu.InIt(mainMenu);

            //Display the menu options
            menu.Display();

            //Instantiate new User and set value to private member field
             _mainUser = new User();

            //Display UI Seperator to make for easier reading
            UI.Seperator();

            //Call selection method to have the user make a menu option choice
            _mainUser = Selection(menu);

          
        }
        //Selection method
        private User Selection(Menu menu)
        {
            //Set values of min and max menu option choices
            int min = 0;
            int max = 2;

            //Ask user to make a selection
            Console.WriteLine("\r\nPlease make a selection by entering the number of the choice you would like.");
            string number = Console.ReadLine();
            int num = Validation.ValidateRange(number,min,max);

            //Switch conditional to determine selection made and 
            switch (num)
            {
                case 0:
                    //Call exit method
                    Exit();
                    break;

                case 1:
                    //Call Login method
                    Login(menu);
                    break;

                case 2:
                    //Call about method
                    About(menu);
                    break;

                case 3:
                    break;


            }
            //Return value to method call
            return _mainUser;

        }
        //Login method
        private void Login(Menu menu)
        {
            //Returned bool value with User login method call
            bool loggedIn = User.Login(_mainUser);

            //Continue method called
            Continue(menu);

        }
        //About method tells about the app
        private void About(Menu menu)
        {
            //Clear console
            Console.Clear();

            //Tell the user that this is the about section
            Console.WriteLine("  This is the about section.  ");

            //Seperator method 
            UI.Seperator();

            Continue(menu);


        }

        //Method to display exit method and return bool value to leave the program
        private void Exit()
        {
            //Clear the console
            Console.Clear();

            //Display to user they have chosen to exit the program and thank them for using the app
            Console.WriteLine("\r\nYou chose to exit the program.\r\n");
            UI.Footer("\r\nThank you for using our App. Press enter to leave.");
            Console.ReadLine();

        }
        //Continue method keeps menu going until exit is chosen
        private void Continue(Menu menu)
        {
            //Ask the user to press any key to continue
            Console.WriteLine("\r\nPlease press any key to continue...");
            Console.ReadLine();

            //Clear the console
            Console.Clear();

            //Display the menu selections again
            menu.Display();

            //UI Seperator method allows for easier reading
            UI.Seperator();

            //Call selection method to run switch again
            Selection(menu);

        }
    }
}
