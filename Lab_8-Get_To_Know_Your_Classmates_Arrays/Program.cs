using System;

namespace Lab_8_Get_To_Know_Your_Classmates_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrays of student names/info
            string[] studentNames = { "Kyle", "Erik", "Jenna", "Sam" };
            string[] favoriteFood = { "Pizza", "Orange Chicken", "PEOPLE!", "Pasta" };
            string[] homeTown = { "Lansing, MI", "Ann Arbor, MI", "Secrect Moon Base", "Toledo, OH" };
            string[] hobbies = { "Playing drums", "Juggling", "REDACTED", "Disc Golf" };

            string userContinue = "y";
            while (userContinue == "y")
            {
                //print student names
                Console.WriteLine("Please choose a student you would like to learn more about: ");
                for (int i = 0; i < studentNames.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {studentNames[i]}");
                }

                //get user selection 1 (which student)
                int userChoice;
                string userChoiceAsString = Console.ReadLine();
                bool userChoiceBool = int.TryParse(userChoiceAsString, out userChoice);
                userChoice = userChoice - 1;

                // selection 1 validation
                while(!userChoiceBool || userChoice > studentNames.Length-1 || userChoice < 0)
                {
                    Console.WriteLine($"Please make a valid selection (1-{studentNames.Length})");
                    userChoiceAsString = Console.ReadLine();
                    userChoiceBool = int.TryParse(userChoiceAsString, out userChoice);
                    userChoice = userChoice - 1;
                }

                // user has made selection 1. Give prompts for selection 2: favorite food, hometown or hobby
                Console.WriteLine($"\nAlright, you have selected {studentNames[userChoice]}. What would you like to know about them?");
                Console.WriteLine("You can ask about 1. Favorite food, 2. Hometown, or 3. Hobby.");

                //print results based on selection 2. should only accept 1, 2, 3, ("favorite food", "hometown", or "hobby" as bonus. Add later)
                int userChoice2;
                string userChoiceAsString2 = Console.ReadLine();
                bool userChoiceBool2 = int.TryParse(userChoiceAsString2, out userChoice2);
                userChoice2 = userChoice2 - 1;

                //selection 2 validation
                while (!userChoiceBool2 || userChoice2 > 3 || userChoice2 < 0)
                {
                    Console.WriteLine("Please make a valid selection (1-3)");
                    userChoiceAsString2 = Console.ReadLine();
                    userChoiceBool2 = int.TryParse(userChoiceAsString2, out userChoice2);
                    userChoice2 = userChoice2 - 1;
                }

                //print results based on selection 1(fav food), 2(hometown), 3(hobby)
                if (userChoice2 == 0)
                {
                    Console.WriteLine($"{studentNames[userChoice]}'s favorite food is {favoriteFood[userChoice]}");
                }
                else if (userChoice2 == 1)
                {
                    Console.WriteLine($"{studentNames[userChoice]} is from {homeTown[userChoice]}");
                }
                else if (userChoice2 == 2)
                {
                    Console.WriteLine($"{studentNames[userChoice]}'s favorite hobby is {hobbies[userChoice]}");
                }
                else
                {
                    Console.WriteLine("Uh oh...");
                }

                //continue
                Console.WriteLine("Would you like to continue? (y/n)");
                userContinue = Console.ReadLine().ToLower();
                while (userContinue != "y" && userContinue != "n")
                {
                    Console.WriteLine("Please enter 'y' or 'n'.");
                    userContinue = Console.ReadLine();
                }
            }
        }
    }
}

