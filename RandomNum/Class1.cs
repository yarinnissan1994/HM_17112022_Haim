using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNum
{
    public class YarinClassRunner
    {
        public static void Run()
        {
            YarinsClass yarinsClass = new YarinsClass();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(yarinsClass.randomNumGenerator());
            }
            Console.WriteLine(yarinsClass.punchLine());
        }
    }
    public class YarinsClass
    {
        Random rnd = new Random();
        public int randomNumGenerator()
        {
            return rnd.Next(100);
        }
        public string punchLine()
        {
             string str = "pride is not the opesite of shame, its the source if it";
             return str;
        }
    }

}



