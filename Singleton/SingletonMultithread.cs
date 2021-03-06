﻿using System;

namespace Singleton
{
    public class SingletonMultithread
    {
        private static SingletonMultithread instance;
        private static object lockObject = new object();
        
        private SingletonMultithread() { }

        public static SingletonMultithread Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                            instance = new SingletonMultithread();
                    }
                }

                return instance;
            }
        }

        public void DoSomething()
        {
            Console.WriteLine("You are running SingletonMultithread.DoSomething() method");
        }
    }
}
