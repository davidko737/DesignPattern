﻿using DesignPattern.Creational.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.AbstractFactory
{

    public class Program
    {
        public static void Main(string[] args)
        {

            ITransportFactory factory1 = new BusTransportFactory();
            ITransport transport1 = factory1.CreateTransport();
            Console.WriteLine(transport1.GetType());

            ITransportFactory factory2 = new FerryTransportFactory();
            ITransport transport2 = factory2.CreateTransport();
            Console.WriteLine(transport2.GetType());
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

    public class Ferry : ITransport
    {
        public string Travel()
        {
            return "Taking ferry";
        }
    }

    public interface ITransportFactory
    {
        public abstract ITransport CreateTransport();
    }

    public class BusTransportFactory : ITransportFactory
    {
        public ITransport CreateTransport()
        {
            return new Bus();
        }
    }

    public class FerryTransportFactory : ITransportFactory
    {
        public ITransport CreateTransport()
        {
            return new Ferry();
        }
    }
}
