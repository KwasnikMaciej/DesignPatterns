using System;

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
