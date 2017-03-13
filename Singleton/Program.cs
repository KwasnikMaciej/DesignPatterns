using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var singletonInstance = Singleton.Instance;
            singletonInstance.DoSomething();

            var singletonStatic = StaticInitializedSingleton.Instance;
            singletonStatic.DoSomething();

            var multithreadSingleton = SingletonMultithread.Instance;
            multithreadSingleton.DoSomething();
            Console.ReadKey();

        }
    }
}
