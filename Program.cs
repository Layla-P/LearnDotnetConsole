using System;
using System.Collections.Generic;

namespace LearnDotnetConsole
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            string myString;

            myString = $"Hello {name}, How old are you?";

            Console.WriteLine(myString);

//            var ageString = Console.ReadLine();
//            int age;
//            int.TryParse(ageString, out age);
            var age = GetAge();
            if (age == 0)
            {
                Console.WriteLine($"Sorry could you write that in numbers, please.");
                age = GetAge();
            }

            DisplayAge(age);

            Console.WriteLine("What foods do you like?");

            var foodString = Console.ReadLine();

            var foodList = FoodsToList(foodString);

            Console.WriteLine($"You like {foodList.Count} foods.  What is your favourite food?");

            var favouriteFood = Console.ReadLine();

            FavouriteFood(favouriteFood, foodList);

            Console.ReadKey();
        }

        private static int GetAge()
        {
            var ageString = Console.ReadLine();
            int age;
            int.TryParse(ageString, out age);
            return age;
        }

        private static void DisplayAge(int age)
        {
            Console.WriteLine($"You are {age} years old.");
        }

        private static List<string> FoodsToList(string foodString)
        {
            List<string> foods = new List<string>();

            var foodArray = StringSplit(foodString);

            foreach (var food in foodArray)
            {
                foods.Add(food.Trim());
            }

            return foods;
        }

        private static string[] StringSplit(string stringToSplit)
        {
            string[] stringArray;

            if (stringToSplit.Contains(","))
            {
                stringArray = stringToSplit.Split(',');
            }
            else
            {
                stringArray = stringToSplit.Split(' ');
            }

            return stringArray;
        }

        private static void FavouriteFood(string favourite, List<string> foodsList)
        {
            var isinList = foodsList.Contains(favourite);
            
            if (!isinList)
            {
                Console.WriteLine($"Hey, {favourite} wasn't in your list!");
            }

            var r = new Random();
            var x = r.Next(foodsList.Count - 1);
            var myFavourite = foodsList[x];

            string response;

            if (isinList && myFavourite == favourite)
            {
                response = $"{myFavourite} is my favourite too!";
            }
            else
            {
                response = $"{myFavourite} is my favourite food";
            }
            
            Console.WriteLine(response);
        }
    }
}