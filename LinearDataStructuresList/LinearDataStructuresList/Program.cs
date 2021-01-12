using System;

namespace LinearDataStructuresList
{
    class Program
    {
        static void Main(string[] args)
        {
            CreatePurchase();
        }

        public static void CreatePurchase()
        {
            CustomArrayList<string> shoppingList = new CustomArrayList<string>();
            
            // Adding elements to the list
            shoppingList.Add("Milk");
            shoppingList.Add("Honey");
            shoppingList.Add("Olives");
            shoppingList.Add("Water");
            shoppingList.Add("Beer");

            // Remove some element from the list
            shoppingList.Remove("Olives");

            // Insert some elements to the list
            shoppingList.Insert(1, "Fruits");
            shoppingList.Insert(0, "Cheese");
            shoppingList.Insert(6, "Vegetables");

            // Remove some element at a specific place
            shoppingList.RemoveAt(0);

            shoppingList[3] = "A lot of " + shoppingList[3];

            Console.WriteLine("We need to buy: ");

            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(" - " + shoppingList[i]);
            }

            Console.WriteLine("Position of 'Beer' = {0}", shoppingList.IndexOf("Beer"));
            Console.WriteLine("Position of 'Water' = {0}", shoppingList.IndexOf("Water"));
            Console.WriteLine("Do we have to buy Bread? " + shoppingList.Contains("Bread"));
        }
    }
}
