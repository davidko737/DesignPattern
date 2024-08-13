using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DelegateEvent_Calculator
{
    public class ResultDisplay
    {
        public void Display(object sender, IntEventArgs e)
        {
            Console.WriteLine($"Result: {e.Value}");
        }
    }
}
