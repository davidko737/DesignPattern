using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DelegateEvent
{

    public class Program
    {
        public static void Main(string[] args)
        {

            // Create instances of TradeService
            TradeService tradeService = new TradeService();

            // Creating a Trade object using object initializer
            Trade trade = new Trade
            {
                TradeId = 1,
                Amount = 1000,
                TraderName = "Alice",
                Price = 150.50m,
                Symbol = "AAPL"
            };


            if (trade != null)
            {
                TradeStatusChangedHandler handler = new TradeStatusChangedHandler(trade);
            }




            // Subscribe to events
            tradeService.TradeExecuted += TradeStatusChangedHandler.OnTradeExecuted;


        }



    }






}

