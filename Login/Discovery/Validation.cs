using System;

//Chase Baier
//ADF
//10/29/2020
//Synopsis: Validation class make sure the user information is correct or they are prompted to re enter their information to something that is acceptable.
namespace Discovery
{
    public static class Validation
    {
        //Validation method to make sure the user entered a string and did not leave blank
        public static string ValidateString(string input)
        {
            while (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Please do not leave blank. Re-enter your answer.");
                input = Console.ReadLine();
            }
            return input;
        }
        //Valation method to make sure the user entered a real number 
        public static int ValidateInteger(string input)
        {
            int i;
            while (!int.TryParse(input,out i))
            {
                Console.WriteLine("Please only enter numbers.");
                input = Console.ReadLine();

            }


            return i;
        }
        //Validate a Range of numbers
        public static int ValidateRange(string number,int min,int max)
        {
            //Clear console
            Console.Clear();
            
            int num;

            while ((!int.TryParse(number,out num)) || string.IsNullOrWhiteSpace(number) || num<min && num>max)
            {
                Console.WriteLine("Please only enter numbers that match the menu options. And do not leave blank.");
                number = Console.ReadLine();

            }

            return num;
        }
    }
}
