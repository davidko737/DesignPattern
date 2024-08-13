using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DelegateEvent_Calculator
{
    public class MathOperations
    {
        // Publisher
        //AdditionPerformed, SubtractionPerformed, MultiplicationPerformed, DivisionPerformed

        public event CalculationHandler AdditionPerformed;
        public event CalculationHandler SubtractionPerformed;
        public event CalculationHandler MultiplicationPerformed;
        public event CalculationHandler DivisionPerformed;

        public void Add(int a, int b)
        {

            AdditionPerformed?.Invoke(this, new IntEventArgs(a+b));
        }

        public void Subtract(int a, int b)
        {
            SubtractionPerformed?.Invoke(this, new IntEventArgs(a-b));
        }

        public void Multipy(int a, int b)
        {
            MultiplicationPerformed?.Invoke(this, new IntEventArgs(a*b));
        }

        public void Divde(int a, int b)
        {
            DivisionPerformed?.Invoke(this, new IntEventArgs(a/b));
        }
    }
}
