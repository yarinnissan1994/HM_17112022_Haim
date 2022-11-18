using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO17112022cs
{
    public class ItemRunner
    {
        public static void Run()
        {
            Item[] itemsArr1 = new Item[2];
            itemsArr1[0] = new Drink(1, "red");
            itemsArr1[1] = new Food(2, 10);

            Item[] itemsArr2 = new Item[10];
            for (int i = 0; i < 10; i++)
            {
                if (i <= 4)
                {
                    itemsArr2[i] = new Drink(i+1, "redBull");
                }
                else
                {
                    itemsArr2[i] = new Food(i + 1, 3 * i);
                }
            }
            for (int i = 0; i < 10; i++)
            {
                itemsArr2[i].Name = "ArrItem" + (i + 1);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("#{0}", itemsArr2[i].Id);
                Console.WriteLine("Item Name: " + itemsArr2[i].Name);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Item[] itemsArr3 = new Item[10];
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                if (rand.Next(1,3) == 1)
                {
                    Console.WriteLine("#{0} Drink", i+1);
                    Console.WriteLine("Please enter drink name: ");
                    string drinkNameInput = Console.ReadLine();
                    Console.WriteLine("Please enter liquid color: ");
                    string liquidColorInput = Console.ReadLine();
                    Console.WriteLine("Please enter price: ");
                    int drinkPriceInput = int.Parse(Console.ReadLine());
                    itemsArr3[i] = new Drink(i + 1, liquidColorInput);
                    itemsArr3[i].Name = drinkNameInput;
                    itemsArr3[i].Price = drinkPriceInput;
                }
                else
                {
                    Console.WriteLine("#{0} Food", i + 1);
                    Console.WriteLine("Please enter food name: ");
                    string foodNameInput = Console.ReadLine();
                    Console.WriteLine("Please enter food weight in grams: ");
                    int weightInput = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter price: ");
                    int foodPriceInput = int.Parse(Console.ReadLine());
                    itemsArr3[i] = new Food(i + 1, weightInput);
                    itemsArr3[i].Name = foodNameInput;
                    itemsArr3[i].Price = foodPriceInput;
                }
            }
            for (int i = 0; i < itemsArr3.Length; i++)
            {
                Console.WriteLine("item ID = {0}", itemsArr3[i].Id);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < itemsArr3.Length; i++)
            {
                if (itemsArr3[i] is Drink)
                {
                    Drink drink = (Drink)itemsArr3[i];
                    Console.WriteLine("#{0} Drink: " + drink.Name, drink.Id);
                    Console.WriteLine(drink.LiquidColor);
                    Console.WriteLine("{0}$", drink.Price);
                    Console.WriteLine();

                }
                else if(itemsArr3[i] is Food)
                {
                    Food food = (Food)itemsArr3[i];
                    Console.WriteLine("#{0} Food:" + food.Name , food.Id);
                    Console.WriteLine("{0}grams", food.Weight);
                    Console.WriteLine("{0}$", food.Price);
                    Console.WriteLine();
                }
            }
        }
        
    }
    internal class Item
    {
        private int _id;
        public int Id
        {
            get { return _id; }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _price;
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public Item(int id)
        {
            _id = id;
        }
    }

    class Drink : Item
    {
        private string _liquidColor;
        public string LiquidColor
        {
            get { return _liquidColor; }
        }

        public Drink (int id, string liquidColor) : base (id)
        {
            _liquidColor = liquidColor;
        }
    }

    class Food : Item
    {
        private int _weight;
        public int Weight
        {
            get { return _weight; }
        }
        
        public Food (int id, int weight) : base(id)
        {
            _weight = weight;
        }
    }
}
