using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petshopforworkers
{
    abstract class Person
    {
        protected string name;
        protected  string number;
        
        public Person() { }
        public Person(string name, string number)
        {
            this.name = name;
            this.number = number;
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
         public string Number
        {
            set
            {
                number = value;
            }
            get
            {
                return number;
            }
        }
        public abstract double dsa();
       
    }
}
