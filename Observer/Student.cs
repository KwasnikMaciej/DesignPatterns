using Observer.Interfaces;
using System;

namespace Observer
{
    public class Student : IObserver
    {
        public void React(NewMessageEvent e)
        {
            Console.WriteLine("Reaction for NewMessageEvent (Header:{0}, Content:{1}) from student", e.Message.Header, e.Message.Content);
        }
    }
}
