using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var messageBoard = new MessageBoard();

            var student = new Student();
            messageBoard.RegisterObserver(student);

            var teacher = new Teacher();
            messageBoard.RegisterObserver(teacher);

            var message = new Message()
            {
                Header = "Test message header",
                Content = "Test message content"
            };

            messageBoard.RegisterNewMessage(message);
            Console.ReadKey();
        }
    }
}
