using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petshopforworkers
{
    abstract class Item:Ipay
    {
        public string name;
       // public double price;
        protected double quantity;
        public double Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
        public Item() { }
        public Item(string name, double quantity)
        {
            this.name = name;
            this.quantity = quantity;
        }
        public abstract double pricing();
       

    }
}
