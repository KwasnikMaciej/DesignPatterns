using Observer.Interfaces;
using System;

namespace Observer
{
    public class Teacher : IObserver
    {
        public void React(NewMessageEvent e)
        {
            Console.WriteLine("Reaction for NewMessageEvent (Header:{0}, Content:{1}) from teacher", e.Message.Header, e.Message.Content);
        }
    }
}
