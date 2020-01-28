using System;

namespace Lab_8_Get_To_Know_Your_Classmates_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //so... we need
            // 1) An set of student info... it's made up of
            int studentIndex = 0;
            //string[] studentNames = { "name0", "name1", "name2" };
            //string[] favoriteFood = { "food0", "food1", "food2" };
            //string[] homeTown = { "town0", "town1", "town2" };
            //string[] whatever = { "whatever0", "whatever1", "whatever2", "whatever" };
            string[] studentNames = { "name0", "name1", "name2" };
            //Console.WriteLine($"Name: {studentNames[0]}, Favorite Food: {favoriteFood[0]}, Hometown {homeTown[0]}");
            Console.WriteLine("Please choose a student you would like to learn more about: ");
            //foreach (string stuname in studentNames)
            //{
            //    Console.Write($"{studentIndex+1}. ");
            //    Console.WriteLine(stuname);
            //}
           
            for (int i = 0; i < studentNames.Length; i++)
            {
                Console.Write($"{i+1}. ");
                Console.WriteLine(GetStudentInfo(studentIndex));
            }
                        
                

        }


        public static string GetStudentInfo(int studentNumber)
        {
            string[] studentNames = { "Alex", "Kyle", "Frank", "Sarah" };
            string[] favoriteFood = { "Pizza", "Meatballs", "Orange Chicken", "Apples" };
            string[] homeTown = { "Lansing, MI", "Ann Arbor, MI", "New York, NY", "Boston, MA" };
            string[] whatever = { "whatever0", "whatever1", "whatever2", "whatever" };

            string stuOutput = ($"Name: {studentNames[studentNumber]}, Favorite Food: {favoriteFood[studentNumber]}, Hometown: {homeTown[studentNumber]}");
            return stuOutput;
        }
    }
}
