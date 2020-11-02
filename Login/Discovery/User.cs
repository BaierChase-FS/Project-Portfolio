using System;

//Chase Baier
//ADF
//10/29/2020
//Synopsis: User class holds information about the user and determines if they are in the system.

namespace Discovery
{
    public class User
    {
        //Fields
        private string name { get; set; }
        private int id { get; set; }
        private string password { get; set; }

        //User constructor
        public User()
        {
            //Set the fields to default values
            name = "Andrew";
            id = 29387;
            password = "RiversAdventures2020+2021!@?";



        }
        //Login method verifies the user account info.
        public static bool Login(User user)
        {
            

            //Set bool value to return
            bool loggedIn = true;

            //Ask user for their ID number
            Console.WriteLine("\r\nPlease enter your user ID number and your password.");
            
            int num = Validation.ValidateInteger(Console.ReadLine());

            //Aske the user for their password
            Console.WriteLine("\r\nPlease enter your password.");
            string pw = Console.ReadLine();
            pw = Validation.ValidateString(pw);

            //SWitch conditional to determine wheter the user info is in the system
            switch (user.password == pw && num == user.id)
            {
                case true:

                    //Change color of text
                    Console.ForegroundColor = ConsoleColor.DarkYellow;

                    //Display user found message and welcome the user
                    Console.WriteLine("\r\n User Found! ");
                    Console.WriteLine($"\r\n Welcome {user.name}");
                    loggedIn = true;

                    break;


                case false:

                    //Display user not found message
                    Console.WriteLine("\r\n User Login not rcognized. ");

                    loggedIn = false;

                    break;

            }

            //Return bool value
            return loggedIn;

        }
    }
}
