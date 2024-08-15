using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.DelegateEvent
{
    // Defing the delegate
    public delegate void NotifyEventHandler(object sender, EventArgs e);

    public class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();

            // Register the event
            publisher.Notify += subscriber.OnNotify;

            publisher.RaiseEvent(EventArgs.Empty);
        }
    }
}
