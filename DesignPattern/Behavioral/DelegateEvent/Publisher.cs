using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.DelegateEvent
{
    public class Publisher
    {
        // Defing the events
        public event NotifyEventHandler Notify;

        public void RaiseEvent(EventArgs e)
        {
            // Raise the event
            Console.WriteLine("Event raised");
            Notify.Invoke(this, e);
        }
    }
}
