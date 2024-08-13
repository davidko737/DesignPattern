using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DelegateEvent
{
    public class Subscriber
    {
        public void OnNotify(object sender, EventArgs e)
        {
            Console.WriteLine("Subscriber: Event received.");
        }
    }
}
