using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.Builder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Trade t = new Trade();
            t.SetDescription("Description").SetName("Description"); 
        }
    }

    public class Trade
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public Trade SetName(string Name)
        {
            Name = Name;
            return this;
        }

        public Trade SetDescription(string Description)
        {
            Description = Description;
            return this;
        }
    }
}
