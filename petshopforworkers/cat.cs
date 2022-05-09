using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petshopforworkers
{
    class cat:Item
    {
        private string type;

        public cat(string name, double quantity, string type):base(name,quantity)
        {         
            this.type = type;
        }
        


        public override double pricing()
        {
            if (type == "Meow Mix Kitten Cat Food 500Gm")
                return quantity * 40;
            if (type == "Meow Mix Kitten Cat Food 1kg")
                return quantity * 70;
            if (type == "Josera JosiCat Beef 10 Kg ")
                return quantity * 280;
            if (type == "Simba Cat Chunkies Beef 415g")
                return quantity * 255;
            if (type == "AVALON Cat Wet Food 410 G")
                return quantity * 235;
            else
                return quantity *310;

        }


    }
}
