using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonOnSiteInterview
{

    public class Burger
    {
        protected string size;
        protected bool cheese = false;
        protected bool pepperoni = false;
        protected bool lettus = false;
        protected bool tomato = false;

        public Burger(BurgerBuilder builder)
        {
            this.size = builder.size;
            this.cheese = builder.cheese;
            this.pepperoni = builder.pepperoni;
            this.lettus = builder.lettus;
            this.tomato = builder.tomato;
            Console.WriteLine("Built Burger");
        }
    }

    public class BurgerBuilder
    {
        public string size;
        public bool cheese { get; set; }
        public bool pepperoni { get; set; }
        public bool lettus { get; set; }
        public bool tomato { get; set; }
        public BurgerBuilder(string size)
        {
            this.size = size;
        }
        public Burger Build()
        {
            return new Burger(this);
        }
    }
}
