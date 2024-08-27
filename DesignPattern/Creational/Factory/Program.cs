using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.Factory.Factory_Transport
{
    // Provides an interface for creating objects,
    // allowing implementing classes to instantiate concrete products
    // without specifying the exact class of the object that will be created.
    // the pattern promotes loose coupling by separating the object's creation logic from its usage,
    // enabling flexibility and extensibility in code.

    public class Program
    {
        public static void Main(string[] args)
        {
            ITransport transport = TransportFactory.Instance.CreateTransport("bus");
            Console.WriteLine(transport.GetType());
        }
    }

    public interface ITransport
    {
        public string Travel();
    }

    public class Bus : ITransport
    {
        public string Travel()
        {
            return "Taking bus";
        }
    }

    public class Ferry: ITransport
    {
        public string Travel()
        {
            return "Taking ferry";
        }
    }

    public interface ITransportFactory
    {
        public abstract ITransport CreateTransport(string transportType);
    }

    public class TransportFactory : ITransportFactory
    {
        private static TransportFactory _instance;
        private TransportFactory() { }

        // Public method to get the singleton instance
        public static TransportFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TransportFactory();
                }
                return _instance;
            }
        }

        public ITransport CreateTransport(string transportType)
        {
            switch (transportType.ToLower())
            {
                case "ferry":
                    return new Ferry();
                case "bus":
                    return new Bus();
                default:
                    throw new ArgumentException("Unknown transport type");
            }
        }
    }
}
