using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO17112022cs
{
    internal class BasePoinetr
    {
        //    public static void Run()
        //    {
        //        Ball a = new Ball();
        //        Toy b = new Toy();

        //        Item item = new Toy();





        //        Ball[] balls = new Ball[10];
        //        Toy[] toys = new Toy[10];
        //        Item[] items = new Item[100];

        //        Random rnd = new Random(DateTime.Now.Millisecond);
        //        for (int i = 0; i < 10; i++)
        //        {
        //            if (rnd.next(1,2)==1)
        //            {
        //                items[i] = new Ball();
        //            }
        //            else
        //            {
        //                items[i] = new Toy();
        //            }
        //        }
        //    }

        class Ball:Item
        {
            public void func2() { }

        }
        class Toy:Item
        {
            public void func3() { }
        }
        class Item
        {
            public void func1() { }
        }
    }
}
