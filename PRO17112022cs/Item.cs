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
            Item[] itemsArr3 = new Item[10];
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                if (rand.Next(1,3) == 1)
                {
                    Console.WriteLine("#{0} Drink - Please enter a liquid color: ", i+1);
                    string liquidColorInput = Console.ReadLine();
                    itemsArr3[i] = new Drink(i + 1, liquidColorInput);
                }
                else
                {
                    Console.WriteLine("#{0} Food - Please enter a food weight: ", i + 1);
                    int weightInput = int.Parse(Console.ReadLine());
                    itemsArr3[i] = new Food(i + 1, weightInput);
                }
            }
            for (int i = 0; i < itemsArr3.Length; i++)
            {
                Console.WriteLine("item ID = {0}", itemsArr3[i].Id);
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
