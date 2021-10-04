using System;

namespace GarbageReport.Infraestructure
{
    public class MessageRepository
    {
        public Message GetFirst()
        {
            var msg = new Message("Hello nurse...");
            return msg;
        }
    }
}
