using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DelegateEvent
{
    public class TradeService
    {
        // Define the events
        public event TradeStatusChangedHandler TradeConfirmed;
        public event TradeStatusChangedHandler TradeCancelled;
        public event TradeStatusChangedHandler TradeExecuted;
        public event TradeStatusChangedHandler TradeCreated;

        public void ExecuteTrade(Trade trade)
        {
            OnTradeExecuted(trade);
        }

        public void OnTradeExecuted(Trade trade)
        {
            // Raise the event
            TradeExecuted.Invoke(trade);
            Console.WriteLine($"Event OnTradeExecuted raised tradeId: {trade.TradeId}");
        }
    }
}
