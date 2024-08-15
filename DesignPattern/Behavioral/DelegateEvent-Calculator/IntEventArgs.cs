using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DelegateEvent_Calculator
{
    public class IntEventArgs : EventArgs
    {
        public int Value { get; }

        public IntEventArgs(int value)
        {
            Value = value;
        }
    }
}
