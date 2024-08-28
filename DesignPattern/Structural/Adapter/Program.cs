using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Adapter
{
    //allow two incompatible interfaces to work together

    public class Program
    {
        public static void Main(string[] args)
        {
            //OldPrinter adaptee = new OldPrinter();
            //adaptee.SayHello();

            OldPrinter oldPrinter = new OldPrinter();
            IPrinter printer = new Adapter(oldPrinter);
            printer.Print();
        }
    }

    // Old Class 
    public class OldPrinter
    {
        public void SayHello()
        {
            Console.WriteLine("Printing document from OldPrinter.");
        }
    }

    public interface IPrinter
    {
        public string Print();  
    }

    public class Adapter: IPrinter
    {
        private readonly OldPrinter _oldPrinter;

        public Adapter(OldPrinter oldPrinter)
        {
            _oldPrinter = oldPrinter;
        }

        public string Print()
        {
            _oldPrinter.SayHello();
            return "Print Done";
        }
    }
}
