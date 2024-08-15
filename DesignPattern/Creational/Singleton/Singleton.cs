using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.Singleton
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object padLock = new Object();
        private static readonly Lazy<Singleton> lazyInstance = new Lazy<Singleton>(() =>
        {
            Console.WriteLine("No Singleton Instance, Create One");
            return new Singleton();
        });


        private Singleton() { }

        //public static Singleton Instance
        //{
        //    get
        //    {
        //        lock (padLock)
        //        {
        //            if (instance == null)
        //            {
        //                Console.WriteLine("No Singleton Instance, Create One");
        //                instance = new Singleton();
        //            }
        //            return instance;
        //        }
        //    }
        //}

        // For lazy instance
        public static Singleton Instance
        {
            get
            {
                return lazyInstance.Value;
            }
        }

        public void SayHello()
        {
            Console.WriteLine("SayHello");
        }
    }
}
