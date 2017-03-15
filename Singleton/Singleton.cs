using System;

namespace Singleton
{
    //WARNING: This is not thread safe!
    public class Singleton
    {
        private static Singleton instance;

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }

                return instance;
            }
        }

        public void DoSomething()
        {
            Console.WriteLine("You are running Singleton.DoSomething() method");
        }
    }
}
