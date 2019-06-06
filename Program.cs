using System;
using System.Collections.Generic;

namespace LearnDotnetConsole
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("How do you like your coffee?");
                        Console.WriteLine("What is your name?");

        
        }

        private static int CheckAge(string ageString)
        {
            int age;

            int.TryParse(ageString, out age);

            if(age == 0)
            {
                Console.WriteLine("Please give me a number");
                ageString = Console.ReadLine();
                int.TryParse(ageString, out age);
            }

            return age;
        }

        private static List<string> GetFoodList(string foodString)
        {
            
            var foodList = new List<string>();

            var foodArray = foodString.Split(" ");

            foreach(var food in foodArray)
            {
                foodList.Add(food);
            }


           return foodList; 
        }

        private static string PickAFood(List<string> list)
        {
            var count = list.Count;

            var r = new Random();

            var indexNumber = r.Next(count-1);

            return list[indexNumber];

        }
    }
}