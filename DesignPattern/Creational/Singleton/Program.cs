using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.Singleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Thread[] threads = new Thread[5];

            for (int i=0; i< threads.Length; i++)
            {
                threads[i] = new Thread(CallingSingleton);
                threads[i].Start(); 
            }
        }

        static void CallingSingleton()
        {
            Singleton instance = Singleton.Instance;
            instance.SayHello();
        }
    }
}
