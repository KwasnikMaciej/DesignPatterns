using Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class MessageBoard : IObservable
    {
        public HashSet<IObserver> Observers { get; set; }

        public List<Message> Messages { get; set; }

        public MessageBoard()
        {
            this.Messages = new List<Message>();
            this.Observers = new HashSet<IObserver>();
        }

        public void RegisterNewMessage(Message message)
        {
            this.Messages.Add(message);
            this.NotifyObservers(new NewMessageEvent
            {
                DateTime = DateTime.Now,
                Message = message
            });
        }

        public void NotifyObservers(NewMessageEvent e)
        {
            Console.WriteLine("Notifying all observers about new event (Message header: {0}, Content: {1})", e.Message.Header, e.Message.Content);
            foreach(var observer in Observers)
            {
                observer.React(e);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            this.Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            this.Observers.Remove(observer);
        }
    }
}
