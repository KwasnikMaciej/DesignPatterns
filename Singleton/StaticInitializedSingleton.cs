using System;

namespace Singleton
{
    public class StaticInitializedSingleton
    {
        private static readonly StaticInitializedSingleton instance = new StaticInitializedSingleton();

        private StaticInitializedSingleton() { }

        public static StaticInitializedSingleton Instance
        {
            get
            {
                return instance;
            }
        }

        public void DoSomething()
        {
            Console.WriteLine("You are running StaticInitializedSingleton.DoSomething() method");
        }
    }
}
