using System;
using System.IO;

namespace ShoppingListProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soovid luua omale poenimekirja? Y/N");
            char userInput = Convert.ToChar(Console.ReadLine().ToLower());

            if (userInput == 'y')
            {
                string rootDirectory = @"C:\Users\...\samples";
                string newDirectory = "shoppingList";
                string fileName = "myshoppingList.txt";

                Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
                File.Create($"{rootDirectory}\\{ newDirectory}\\{fileName}");

                Console.WriteLine("Sinu fail on loodud!");
            }
            else
            {
                Console.WriteLine("Pole viga, vahest järgmine kord!");
            }
        }
    }
}
