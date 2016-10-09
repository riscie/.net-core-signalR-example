using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignarRChat.Model
{
    public class Message
    {
        public Message(string body)
        {
            this.Body = body;
        }

        public string Body;
    }
}