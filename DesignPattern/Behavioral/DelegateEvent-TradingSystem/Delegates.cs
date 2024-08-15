using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DelegateEvent
{

    public delegate void TradeStatusChangedHandler(Trade trade);

    public delegate void EmailNotification(Trade trade);
}
