using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Item
    {
        private int _id;
        public int Id { get { return _id; } }
        public string Name { get; set; }
        public int Price { get; set; }

        public Item(int id)
        {
            this._id = id;
        }
    }
    public class Drink : Item
    {
        private string _LiquidColor;
        public string LiquidColor { get { return _LiquidColor; } set { this._LiquidColor = value; } }
        public Drink(int id) : base(id)
        {

        }
    }

    public class Food : Item
    {
        public int Weight { get { return Weight; } set { this.Weight = value; } }
        public Food(int id) : base(id)
        {

        }
    }
}

