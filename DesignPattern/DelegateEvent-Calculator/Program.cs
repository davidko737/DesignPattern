using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DelegateEvent_Calculator
{
   // Define delegates
   public delegate void CalculationHandler(object sender, IntEventArgs e);

    public class Program
    {
        public static void Main(string[] args)
        {
            // addition, subtraction, multiplication, or division
            
            MathOperations mathOperations = new MathOperations(); 
            ResultDisplay resultDisplay = new ResultDisplay();  

            mathOperations.AdditionPerformed += resultDisplay.Display;
            mathOperations.SubtractionPerformed += resultDisplay.Display;
            mathOperations.MultiplicationPerformed += resultDisplay.Display;
            mathOperations.DivisionPerformed += resultDisplay.Display;

            mathOperations.Add(10, 5);
            mathOperations.Add(1240, 5);
            mathOperations.Subtract(10, 5);
            mathOperations.Multipy(10, 5);
        }
    }
}
