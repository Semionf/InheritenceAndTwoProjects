using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project2;
namespace Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item[] list = new Item[2];
            Item[] itemList = new Item[10];
            Random rand = new Random(DateTime.Now.Millisecond);
            list[0] = new Drink(1);
            list[1] = new Food(2);

            for (int i = 0; i < 10; i++)
            {
                if(i < 5)
                {
                    itemList[i] = new Drink(i + 20);
                    itemList[i].Name = "Shoko";                }
                else
                {
                    itemList[i] = new Food(i+20);
                    itemList[i].Name = "Bamba";
                }
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("The ID is: " + itemList[i].Id + "The Name is: " + itemList[i].Name);
            }

            Item[] itemBigList = new Item[100];
            for (int i = 0; i < 10; i++)
            {
                if(rand.Next(1,2) == 1)
                {
                    itemBigList[i] = new Drink(i+30);
                    Console.WriteLine("Please enter name: ");
                    itemBigList[i].Name= Console.ReadLine();
                    Console.WriteLine("Please enter price: ");
                    itemBigList[i].Price = int.Parse(Console.ReadLine());
                }
                else
                {
                    itemBigList[i] = new Food(i + 30);
                    Console.WriteLine("Please enter name: ");
                    itemBigList[i].Name = Console.ReadLine();
                }
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ID: " +itemBigList[i].Id + "Name: "+itemBigList[i].Name);
            }
            for (int i = 0; i < 10; i++)
            {
                if (itemBigList[i] is Food)
                {
                    Food f = (Food)itemBigList[i];
                    Console.WriteLine(f.Name, f.Price, f.Weight);
                }
                else
                {
                    Drink d = (Drink)itemBigList[i];
                }
            }
        }
    }
}
