using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ShoppingListProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\...\samples\shoppingList";
            string fileNamed = @"\\myshoppingList.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileNamed}");
            List<string> myshoppingList = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Soovid lisada eseme ostunimekirja? Y/N");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Sisesta ese:");
                    string userWish = Console.ReadLine();
                    myshoppingList.Add(userWish);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Kena päeva!");
                }
            }

            Console.Clear();

            foreach (string wish in myshoppingList)
            {
                Console.WriteLine($"Sinu nimekirjas: {wish}");
            }

            File.WriteAllLines($"{fileLocation}{fileNamed}", myshoppingList);

        }
    }
}
