using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    internal class _BasePointer
    {
        public static void Run()
        {
            Ball a = new Ball(12);
            Toy b = new Toy(13);
            Item item;

            item = a;
            item = b;
            Random rand = new Random(DateTime.Now.Millisecond);
            Item[] itemList = new Item[100];
            for (int i = 0; i < 100; i++)
            {
                if(rand.Next(1,2) == 1)
                {
                    itemList[i] = new Ball(i);
                }
                else
                {
                    itemList[i] = new Toy(i);
                }
            }
        }

        class Ball: Item
        {
            public Ball(int Id):base(Id)
            { 
                
            }
        }
        class Toy : Item
        {
            public Toy(int Id):base(Id)
            {

            }
        }
        class Item 
        {
            public int Id;
            public string Name;
            public int Price;

            public Item(int Id)
            {
                this.Id = Id;
            }
        }
    }
}
