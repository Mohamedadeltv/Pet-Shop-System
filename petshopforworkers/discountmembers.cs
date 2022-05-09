using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petshopforworkers
{
    class Discountmembers:Person
    {
        private double discount=0;

        public Discountmembers(string name, string number,string promocode):base(name,number)
        {
            if (promocode == "adel1021") //for all users
            {
                discount = 0.15;
            }
            if(name == "adel" && promocode == "ADEL85949") //for that specific user
            {
                discount = 0.3;
            }

        }
        //public double Discount
        //{
        //    get
        //    {
        //        return discount;
        //    }
        //    set
        //    {
        //        discount = value;
        //    }
        // }
        public override double dsa()
        {
            return discount;
        }

    }
}
