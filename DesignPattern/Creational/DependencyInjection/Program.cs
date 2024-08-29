using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.DependencyInjection
{

    // DI is a design pattern that allows objects to receive their dependencies
    // from an external source rather than creating them internally
    public class Program
    {
        public static void Main(string[] args)
        {
            TradeService ts = new TradeService(new TradeRepository());
            ts.Process();
        }
    }

    public class TradeService
    {
        private readonly TradeRepository tradeRepository;

        public TradeService(TradeRepository tradeRepository)
        {
            this.tradeRepository = tradeRepository;
        }

        public void Process()
        {
            Console.WriteLine("Trade processed");
            tradeRepository.UpdateTradeStatus("Live");
        }
    }

    public class TradeRepository
    {
        public void UpdateTradeStatus(string status)
        {
            Console.WriteLine("Status Updated");
        }
    }
}
