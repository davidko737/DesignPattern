using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DelegateEvent
{
    public class Trade
    {
        public decimal TradeId { get; set; }
        public decimal Amount { get; set; }
        public string TraderName { get; set; }
        public decimal Price { get; set; }
        public string Symbol { get; set; }

    }
}
