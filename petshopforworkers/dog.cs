using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petshopforworkers
{
    class dog:Item
    {
        private string type;

        public dog() { }
        public dog(string name, double quantity, string type) : base(name, quantity)
        {
            this.type = type;
        }
        public override double pricing()
        {
            if (type == "Bavaro Force 18KG")
            {
               // if (quantity >= 4)
                 //   return quantity * 200 * 0.8;
               // else
                return quantity * 200;
            }
            if (type == "Dog Chow Complete8.39 KG")
                return quantity * 370;
            if (type == "Josera Poultry For Dogs 15 KG ")
                return quantity * 150;
            if (type == "Teddy Dog Wet Food  Beef 1Kg")
                return quantity * 30;
            if (type == "Royal Yorkshire Adult Loaf 85g")
                return quantity * 18;
            else
                return quantity * 340;

        }

        public double bavarondiscount()
        {
            if (quantity >= 4)
                return quantity * 200 * 0.4;
            else
                return 0;


        }
    }
}
