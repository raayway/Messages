using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    public class MessageModel:IMessageModel
    {
        private List<Message> messages { get; set; }

        public MessageModel()
        {
            messages = new List<Message>();
        }

        public int AddMessage(Message message)
        {
            var index = messages.FindIndex(msg => msg.Id == message.Id);
            if (index >= 0)
            {
                message.Id = messages.Max(msg => msg.Id) + 1;
            }
            messages.Add(message);
            return message.Id;
        }

        public int RemoveMessage(int id)
        {
            var tempMsg = messages.Find(msg => msg.Id == id);
            messages.Remove(tempMsg);
            return tempMsg.Id;
        }

        public List<Message> Messages
        {
            get { return messages; }
        }

    }
}
