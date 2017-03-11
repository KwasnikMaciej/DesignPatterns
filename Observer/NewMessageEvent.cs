using System;

namespace Observer
{
    public class NewMessageEvent
    {
        public DateTime DateTime { get; set; }

        public Message Message { get; set; }
    }
}
